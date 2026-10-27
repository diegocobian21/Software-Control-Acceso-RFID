using INTERFAZ_PC.Data;
using INTERFAZ_PC.Security;
using MySql.Data.MySqlClient;

namespace INTERFAZ_PC.Repositories
{
    /// <summary>
    /// Acceso a datos para la tabla "administradores".
    /// Esta tabla NO existía en el esquema original: el login de admin
    /// estaba hardcodeado ("CssAdmin"/"safe123") directamente en
    /// Login.cs. Ver README_REFACTOR.md para el script SQL que crea
    /// esta tabla y cómo dar de alta el primer administrador.
    /// </summary>
    public class AdministradorRepository
    {
        public bool ValidarCredenciales(string usuario, string contrasenaPlano)
        {
            const string sql = "SELECT CLAVE FROM administradores WHERE USUARIO = @usuario LIMIT 1";

            using MySqlConnection conexion = ConnectionFactory.CrearConexion();
            conexion.Open();

            using var comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            object? resultado = comando.ExecuteScalar();
            if (resultado is null)
            {
                return false;
            }

            string hashGuardado = resultado.ToString() ?? string.Empty;
            return PasswordHasher.Verify(contrasenaPlano, hashGuardado);
        }
    }
}
