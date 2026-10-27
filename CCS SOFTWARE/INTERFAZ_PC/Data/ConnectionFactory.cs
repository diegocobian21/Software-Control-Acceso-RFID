using System.Configuration;
using MySql.Data.MySqlClient;

namespace INTERFAZ_PC.Data
{
    /// <summary>
    /// Punto único para crear conexiones a la base de datos.
    /// La cadena de conexión YA NO vive hardcodeada en el código: se lee
    /// de App.config (sección &lt;connectionStrings&gt;), así que cambiar
    /// servidor/usuario/contraseña no requiere recompilar.
    /// </summary>
    public static class ConnectionFactory
    {
        private const string ConnectionStringName = "css";

        public static MySqlConnection CrearConexion()
        {
            string? cadena = ConfigurationManager.ConnectionStrings[ConnectionStringName]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(cadena))
            {
                throw new ConfigurationErrorsException(
                    $"No se encontró la cadena de conexión '{ConnectionStringName}' en App.config.");
            }

            return new MySqlConnection(cadena);
        }

        /// <summary>
        /// Prueba la conexión a la base de datos. Útil para un botón
        /// "probar conexión" en una pantalla de configuración.
        /// </summary>
        public static bool ValidarConexion()
        {
            try
            {
                using MySqlConnection conexion = CrearConexion();
                conexion.Open();
                return conexion.State == System.Data.ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }
    }
}
