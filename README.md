# CCS SOFTWARE / INTERFAZ_PC

App de control de acceso con RFID (guardias, usuarios registrados e invitados)
hecha en WinForms (C#, .NET 6) con MySQL, y un Arduino que lee las tarjetas
NFC por puerto serial.

## Configuración inicial (antes de compilar)

Este repo NO incluye `App.config` (trae tu contraseña real de MySQL, así que
se ignora por git — ver `.gitignore`). Para dejarlo listo:

1. Copia `CCS SOFTWARE/INTERFAZ_PC/App.config.example` a
   `CCS SOFTWARE/INTERFAZ_PC/App.config` (mismo folder).
2. Abre ese `App.config` nuevo y reemplaza `Uid`/`Pwd` por tu usuario y
   contraseña reales de MySQL.
3. Corre `crear_base_datos_CSS.sql` en MySQL Workbench para crear la base
   `CSS` y sus tablas.

Con eso el proyecto compila y conecta a tu base local.

---

Lo que sigue resume qué cambió en el refactor de seguridad/arquitectura, qué
tienes que hacer tú manualmente en la base de datos, y qué quedó pendiente.

## 1. Qué se corrigió

| Problema original | Solución aplicada |
|---|---|
| SQL armado con concatenación de strings (inyección SQL) en `DBconexion.cs`, `RegisterUsers.cs`, `RegisterGuards.cs`, `Guests.cs` | Todas las consultas ahora usan `MySqlParameter` (`@nombre`, `@telefono`, etc.) |
| Login con usuario/contraseña hardcodeados (`"Css"/"safe123"`, `"CssAdmin"/"safe123"`) en `Login.cs` | Login valida contra la base de datos usando hash BCrypt. Admin valida contra una tabla nueva `administradores` (ver sección 2) |
| Contraseñas en texto plano en las columnas `CLAVE` / `CONTRASEÑA` | Se hashean con `BCrypt.Net-Next` antes de insertarse (`Security/PasswordHasher.cs`) |
| Cadena de conexión hardcodeada y repetida en cada método de `DBconexion.cs` | Ahora vive en un solo lugar: `App.config` → `<connectionStrings>`, leída por `Data/ConnectionFactory.cs` |
| Conexiones abiertas sin `using` (fuga de conexiones si hay excepción) | Todo el acceso a datos nuevo usa `using` |
| `List<object>` + casteo manual | Listas tipadas: `List<Usuario>`, `List<Guardia>`, `List<Invitado>` (carpeta `Models/`) |
| Toda la lógica de acceso a datos mezclada en una sola clase `DBconexion` | Separada en `Repositories/UsuarioRepository.cs`, `GuardiaRepository.cs`, `InvitadoRepository.cs`, `AdministradorRepository.cs` |
| Referencia rota a MySql.Data con ruta absoluta de la PC del desarrollador original | Se quitó; el `PackageReference` de NuGet ya trae el ensamblado |

### Archivos nuevos
```
Data/ConnectionFactory.cs
Models/Usuario.cs
Models/Guardia.cs
Models/Invitado.cs
Repositories/UsuarioRepository.cs
Repositories/GuardiaRepository.cs
Repositories/InvitadoRepository.cs
Repositories/AdministradorRepository.cs
Security/PasswordHasher.cs
```

### Archivos modificados
```
App.config
INTERFAZ_PC.csproj
DBconexion.cs      (ahora es una fachada de compatibilidad, ver sección 4)
Login.cs
RegisterUsers.cs
RegisterGuards.cs
Guests.cs
```

### Archivos NO tocados (siguen igual que el original)
`Ausers.cs`, `Guards.cs`, `Monitoring.cs`, `NFC_Admins.cs`, `nfc_guards.cs`,
`AReport.cs`, `GReport.cs`, `StartProgram.cs`, `Initiation_Admin.cs`,
`Initiation_Guards.cs`, `Entidades.cs`, `Form1.cs`, `Program.cs`, y todos
los `*.Designer.cs` / `*.resx`. Siguen funcionando porque `DBconexion.cs`
se dejó como fachada (ver sección 4).

## 2. Pasos que debes correr en la base de datos ANTES de compilar

**a) Amplía el tamaño de las columnas de contraseña.** Un hash BCrypt mide
~60 caracteres. Si tus columnas `CLAVE` (tabla `usuarios`) y `CONTRASEÑA`
(tabla `guardias`) son `VARCHAR` más cortas, el insert va a truncar el hash
y el login nunca va a funcionar:

```sql
ALTER TABLE usuarios  MODIFY CLAVE       VARCHAR(255) NOT NULL;
ALTER TABLE guardias  MODIFY CONTRASEÑA  VARCHAR(255) NOT NULL;
```

**b) Crea la tabla `administradores`.** No existía en el esquema original
— el login de admin estaba hardcodeado en el código. Ahora necesita su
propia tabla:

```sql
CREATE TABLE administradores (
    id      INT AUTO_INCREMENT PRIMARY KEY,
    USUARIO VARCHAR(50)  NOT NULL UNIQUE,
    CLAVE   VARCHAR(255) NOT NULL
);
```

**c) Genera el hash para el primer administrador.** Como las contraseñas
ya no se escriben en el código, necesitas generar un hash BCrypt una sola
vez. La forma más simple: agrega temporalmente estas dos líneas al inicio
de `Program.cs` (dentro de `Main`, antes de `Application.Run`), corre el
programa una vez, copia el hash que aparece en la consola, y luego
**borra esas dos líneas**:

```csharp
Console.WriteLine(INTERFAZ_PC.Security.PasswordHasher.Hash("tu_password_aqui"));
return;
```

Con ese hash, inserta el admin:

```sql
INSERT INTO administradores (USUARIO, CLAVE)
VALUES ('CssAdmin', '<pega_aquí_el_hash_generado>');
```

**d) Migra las contraseñas existentes de `usuarios` y `guardias`.** Si ya
tienes registros con contraseñas en texto plano, no hay forma automática
de "hashear hacia atrás" — tienes dos opciones:
- Pedir a cada usuario/guardia que resetee su contraseña (recomendado), o
- Escribir un script de migración de una sola corrida que lea cada fila,
  hashee el valor actual con `PasswordHasher.Hash(...)` y lo actualice con
  `UPDATE ... WHERE id = @id`. Si quieres, te ayudo a escribirlo.

## 3. Pasos para compilar

1. Abre `CCS SOFTWARE/INTERFAZ_PC/INTERFAZ_PC.sln` en Visual Studio.
2. Restaura paquetes NuGet (botón derecho en la solución → *Restore NuGet
   Packages*, o simplemente compila y Visual Studio lo hace solo). Esto
   va a descargar `BCrypt.Net-Next` y `System.Configuration.ConfigurationManager`,
   que son nuevos.
3. Revisa que `App.config` tenga los datos correctos de tu servidor MySQL
   (usuario, contraseña, host) en `connectionStrings`.
4. Corre los pasos de la sección 2 contra tu base de datos.
5. Compila y corre.

## 4. Sobre `DBconexion.cs`

Se dejó como una **fachada de compatibilidad**: internamente ya delega en
los repositorios nuevos (parametrizados, con `using`), pero mantiene los
mismos nombres de método (`consulta`, `consultaGuardias`, `eliminar`, etc.)
para que `Ausers.cs`, `Guards.cs` y `StartProgram.cs` —que no se tocaron—
sigan compilando sin cambios.

Cuando tengas tiempo de revisar esas pantallas, lo ideal es que dejen de
usar `DBconexion` y llamen directamente a `UsuarioRepository` /
`GuardiaRepository`, y entonces puedes borrar `DBconexion.cs`.

## 5. Qué quedó pendiente (fuera del alcance de este refactor)

- **Multi-targeting en `obj/`**: se veían builds viejos de net5.0 y
  netcoreapp3.0. El `.csproj` ya apunta solo a `net6.0-windows`; borra las
  carpetas `bin/` y `obj/` una vez antes de compilar para limpiar rastros
  viejos.
- **Convenciones de nombres inconsistentes** (`Guards.cs` vs `guardias.cs`,
  propiedades en minúscula en `Entidades.cs`): no se tocó para no romper
  los formularios no refactorizados, que dependen de esos nombres exactos.
  Es un buen siguiente paso una vez que decidas refactorizar esas pantallas
  también.
- **Manejo de errores**: los repositorios nuevos todavía hacen
  `Console.WriteLine` en el catch (en vez de un logger real). En una app
  WinForms nadie ve la consola — valdría la pena mostrar el error al
  usuario o usar un logger (Serilog, por ejemplo).
- **No hay tests.** Ninguno de los proyectos .NET que mencionaste en tu
  perfil (este ni los otros) tiene pruebas unitarias todavía; los
  repositorios nuevos están diseñados para ser fáciles de probar (reciben
  `ConnectionFactory` implícitamente, podrías inyectar la conexión si más
  adelante quieres mockear la BD).
