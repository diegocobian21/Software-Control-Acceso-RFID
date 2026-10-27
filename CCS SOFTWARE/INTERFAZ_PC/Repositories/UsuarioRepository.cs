using System;
using System.Collections.Generic;
using INTERFAZ_PC.Data;
using INTERFAZ_PC.Models;
using MySql.Data.MySqlClient;

namespace INTERFAZ_PC.Repositories
{
    /// <summary>
    /// Acceso a datos para la tabla "usuarios".
    /// Reemplaza los métodos de usuarios que vivían en DBconexion.cs.
    /// Todas las consultas usan parámetros (@param) en vez de concatenar
    /// strings, lo que elimina el riesgo de inyección SQL.
    ///
    /// Esta clase NO conoce la UI (no usa MessageBox ni nada de
    /// System.Windows.Forms): solo devuelve true/false. Si el formulario
    /// que la llama necesita avisarle algo al usuario, lo hace él mismo
    /// revisando el valor que devuelve cada método.
    /// </summary>
    public class UsuarioRepository
    {
        public List<Usuario> Buscar(string? filtro)
        {
            var lista = new List<Usuario>();

            string sql = "SELECT id, NOMBRE, TELEFONO, CORREO, CLAVE, HORARIO, OCUPACION, AREA, CARRERA, UID, HORA_ENTRADA, HORA_SALIDA " +
                         "FROM usuarios ";

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                sql += "WHERE NOMBRE LIKE @filtro OR TELEFONO LIKE @filtro OR CORREO LIKE @filtro " +
                       "OR HORARIO LIKE @filtro OR OCUPACION LIKE @filtro OR AREA LIKE @filtro " +
                       "OR CARRERA LIKE @filtro OR UID LIKE @filtro ";
            }

            sql += "ORDER BY NOMBRE ASC";

            using MySqlConnection conexion = ConnectionFactory.CrearConexion();
            conexion.Open();

            using var comando = new MySqlCommand(sql, conexion);
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                comando.Parameters.AddWithValue("@filtro", $"%{filtro}%");
            }

            using MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Usuario? BuscarPorUid(string uid)
        {
            const string sql = "SELECT id, NOMBRE, TELEFONO, CORREO, CLAVE, HORARIO, OCUPACION, AREA, CARRERA, UID, HORA_ENTRADA, HORA_SALIDA " +
                                "FROM usuarios WHERE UID = @uid LIMIT 1";

            using MySqlConnection conexion = ConnectionFactory.CrearConexion();
            conexion.Open();

            using var comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@uid", uid);

            using MySqlDataReader reader = comando.ExecuteReader();
            return reader.Read() ? Mapear(reader) : null;
        }

        /// <summary>
        /// Inserta un usuario. Clave debe llegar ya hasheada
        /// (usar Security.PasswordHasher.Hash antes de llamar esto).
        /// </summary>
        public bool Insertar(Usuario usuario)
        {
            const string sql = "INSERT INTO usuarios (NOMBRE, TELEFONO, CORREO, CLAVE, HORARIO, OCUPACION, AREA, CARRERA, UID) " +
                                "VALUES (@nombre, @telefono, @correo, @clave, @horario, @ocupacion, @area, @carrera, @uid)";

            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();

                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                comando.Parameters.AddWithValue("@correo", usuario.Correo);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@horario", usuario.Horario);
                comando.Parameters.AddWithValue("@ocupacion", usuario.Ocupacion);
                comando.Parameters.AddWithValue("@area", usuario.Area);
                comando.Parameters.AddWithValue("@carrera", usuario.Carrera);
                comando.Parameters.AddWithValue("@uid", usuario.Uid);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar usuario: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM usuarios WHERE id = @id";

            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();

                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar usuario: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Registra la hora de entrada de un usuario por su UID y limpia
        /// su hora de salida previa. Devuelve false si el UID no existe
        /// en la tabla (0 filas afectadas) o si hubo un error de BD.
        /// </summary>
        public bool RegistrarEntrada(string uid)
        {
            string fechaHoraMySQL = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Usamos NULL en vez de '' para columnas DATETIME.
            const string sql = "UPDATE usuarios SET HORA_ENTRADA = @hora, HORA_SALIDA = NULL WHERE TRIM(UID) = @uid";

            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();
                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@hora", fechaHoraMySQL);
                comando.Parameters.AddWithValue("@uid", uid.Trim());

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al registrar entrada de usuario: " + ex.Message);
                return false;
            }
        }

        public bool RegistrarSalida(string uid)
        {
            string fechaHoraMySQL = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            const string sql = "UPDATE usuarios SET HORA_SALIDA = @hora WHERE TRIM(UID) = @uid";

            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();
                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@hora", fechaHoraMySQL);
                comando.Parameters.AddWithValue("@uid", uid.Trim());

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al registrar salida de usuario: " + ex.Message);
                return false;
            }
        }

        private static Usuario Mapear(MySqlDataReader reader)
        {
            return new Usuario
            {
                Id = reader.GetInt32("id"),
                Nombre = reader["NOMBRE"].ToString() ?? string.Empty,
                Telefono = reader["TELEFONO"].ToString() ?? string.Empty,
                Correo = reader["CORREO"].ToString() ?? string.Empty,
                Clave = reader["CLAVE"].ToString() ?? string.Empty,
                Horario = reader["HORARIO"].ToString() ?? string.Empty,
                Ocupacion = reader["OCUPACION"].ToString() ?? string.Empty,
                Area = reader["AREA"].ToString() ?? string.Empty,
                Carrera = reader["CARRERA"].ToString() ?? string.Empty,
                Uid = reader["UID"].ToString() ?? string.Empty,
                HoraEntrada = reader["HORA_ENTRADA"].ToString() ?? string.Empty,
                HoraSalida = reader["HORA_SALIDA"].ToString() ?? string.Empty,
            };
        }
    }
}
