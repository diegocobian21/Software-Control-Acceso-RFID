# CCS SOFTWARE / INTERFAZ_PC

App de control de acceso con RFID (guardias, usuarios registrados e invitados)
hecha en WinForms (C#, .NET 6) con MySQL, y un Arduino que lee las tarjetas
NFC por puerto serial (COM6).

## Circuito Arduino RFID
<img width="720" height="1280" alt="circuito RFID" src="https://github.com/user-attachments/assets/bf2b6f64-96ce-429d-9df2-cc92b357060a" />

## Configuración inicial (antes de compilar)

Este repo NO incluye `App.config` (trae tu contraseña real de MySQL, así que
se ignora por git — ver `.gitignore`). Para dejarlo listo:

1. Copia `CCS SOFTWARE/INTERFAZ_PC/App.config.example` a
   `CCS SOFTWARE/INTERFAZ_PC/App.config` (mismo folder).
2. Abre ese `App.config` nuevo y reemplaza `Uid`/`Pwd` por tu usuario y
   contraseña reales de MySQL.
3. Corre `crear_base_datos_CSS.sql` (en la raíz del repo) en MySQL
   Workbench para crear la base `CSS` y todas sus tablas, ya con las
   columnas correctas (incluida `administradores`, que no existía en el
   proyecto original).

## Compilar y correr

1. Abre `CCS SOFTWARE/INTERFAZ_PC/INTERFAZ_PC.sln` en Visual Studio 2022.
2. Compila una vez para que restaure los paquetes NuGet (`MySql.Data`,
   `BCrypt.Net-Next`, `System.Configuration.ConfigurationManager`).
3. Confirma que tu Arduino esté conectado y aparezca como **COM6** en el
   Administrador de dispositivos (si tu Arduino usa otro puerto, cambia
   `"COM6"` en `Guests.cs`, `Monitoring.cs`, `RegisterUsers.cs` y
   `RegisterGuards.cs` — son los únicos 4 formularios que abren el
   puerto serial).
4. Antes del primer login, genera el administrador inicial (ver abajo).
5. Compila y corre (F5).

### Generar el primer administrador

El script SQL no inserta ningún administrador (las contraseñas se guardan
como hash BCrypt, nunca en texto plano, así que no se puede "precargar" un
INSERT con la contraseña visible). Para crear el primero:

1. Agrega temporalmente estas dos líneas al inicio de `Main()` en
   `Program.cs`, antes de crear el `ApplicationContext`:
   ```csharp
   Console.WriteLine(INTERFAZ_PC.Security.PasswordHasher.Hash("tu_password_aqui"));
   return;
   ```
2. Corre el programa una vez (verás el hash en la ventana de consola),
   copia el hash y **borra esas dos líneas**.
3. Inserta el administrador con ese hash:
   ```sql
   INSERT INTO administradores (USUARIO, CLAVE)
   VALUES ('CssAdmin', '<pega_aquí_el_hash_generado>');
   ```

## Arquitectura

```
Models/            Usuario, Guardia, Invitado — únicas clases que representan
                   estos datos en todo el proyecto (antes había varias
                   clases distintas y duplicadas para lo mismo).
Repositories/      Todo el acceso a MySQL: UsuarioRepository, GuardiaRepository,
                   InvitadoRepository, AdministradorRepository. Consultas
                   parametrizadas (sin concatenar strings), sin dependencia
                   de System.Windows.Forms — no muestran MessageBox, solo
                   devuelven datos/bool; la UI decide qué mostrar.
Data/              ConnectionFactory.cs — crea la conexión MySQL leyendo
                   la cadena de conexión desde App.config (sección
                   <connectionStrings>, nombre "css").
Security/          PasswordHasher.cs — hash y verificación de contraseñas
                   con BCrypt.
Navigation/        FormNavigator.cs — navegación entre pantallas que de
                   verdad libera memoria (ver más abajo).
```

## Navegación entre formularios

El proyecto usa dos patrones distintos, según si la pantalla usa el puerto
serial COM6 o no:

- **Pantallas normales** (Login, Initiation_Admin, Initiation_Guards,
  Ausers, Guards, AReport, GReport): usan `FormNavigator.NavegarA(this, new
  Destino())`, que muestra la pantalla destino y cierra (`Close()`) la
  actual — a diferencia del patrón viejo (`Show()` + `Hide()`), esto sí
  destruye la ventana anterior en vez de dejarla oculta y viva en memoria
  ("ventana fantasma").
- **Las 4 pantallas que usan el puerto COM6** (`Guests`, `Monitoring`,
  `RegisterGuards`, `RegisterUsers`): nunca usan `FormNavigator`. Siempre
  se abren como diálogo modal (`ShowDialog()`) desde una pantalla que no
  usa el puerto, y su botón de "volver" solo hace `this.Close()` para
  regresar a quien las abrió. Así nunca hay dos formularios compitiendo
  por el mismo puerto COM6 al mismo tiempo.

## Seguridad: qué se corrigió respecto al proyecto original

| Problema original | Solución aplicada |
|---|---|
| SQL armado con concatenación de strings (inyección SQL) | Todas las consultas usan `MySqlParameter` (`@nombre`, `@telefono`, etc.) |
| Login con usuario/contraseña hardcodeados en el código | Login valida contra la base de datos; el admin tiene su propia tabla `administradores` |
| Contraseñas en texto plano en las columnas `CLAVE` / `CONTRASEÑA` | Se hashean con `BCrypt.Net-Next` antes de guardarse (`Security/PasswordHasher.cs`) |
| Cadena de conexión hardcodeada y repetida en cada método de una clase `DBconexion` | Vive en un solo lugar: `App.config`, leída por `Data/ConnectionFactory.cs`. La clase `DBconexion` ya no existe. |
| Conexiones abiertas sin `using` (fuga de conexiones si hay excepción) | Todo el acceso a datos usa `using` |
| `List<object>` + casteo manual, varias clases duplicadas para el mismo dato | Modelos tipados únicos en `Models/` (`Usuario`, `Guardia`, `Invitado`) |
| Navegación con `Show()` + `Hide()` acumulando ventanas ocultas en memoria | `FormNavigator` (cierra de verdad) + diálogo modal para las pantallas que usan el puerto serial |

## Pendiente / posibles siguientes pasos

- **No hay tests.** Los repositorios están pensados para ser fáciles de
  probar (reciben la conexión a través de `ConnectionFactory`), pero no
  hay pruebas unitarias todavía.
- **Manejo de errores**: los repositorios hacen `Console.WriteLine` en el
  catch en vez de un logger real — en una app WinForms nadie ve la
  consola en producción. Valdría la pena un logger (Serilog, por
  ejemplo) o reportar el error de otra forma hacia la UI.
- **`Program.cs`** actualmente puede estar apuntando a una pantalla
  distinta de `StartProgram`/`Login` para pruebas rápidas de un
  formulario en particular — antes de distribuir una versión final,
  confirma que `Application.Run`/`ApplicationContext` en `Program.cs`
  arranque en la pantalla que de verdad quieres como punto de entrada
  (por ejemplo, `StartProgram` para pasar primero por el login).
