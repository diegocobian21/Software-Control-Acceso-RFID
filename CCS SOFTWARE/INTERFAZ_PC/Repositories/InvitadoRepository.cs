using System;
using System.Collections.Generic;
using INTERFAZ_PC.Data;
using INTERFAZ_PC.Models;
using MySql.Data.MySqlClient;

namespace INTERFAZ_PC.Repositories
{
    /// <summary>
    /// Acceso a datos para la tabla "invitados".
    ///
    /// Esta clase NO conoce la UI (no usa MessageBox ni nada de
    /// System.Windows.Forms): solo devuelve true/false. Si el formulario
    /// que la llama necesita avisarle algo al usuario, lo hace él mismo
    /// revisando el valor que devuelve cada método.
    /// </summary>
    public class InvitadoRepository
    {
        public List<Invitado> Buscar(string? filtro)
        {
            var lista = new List<Invitado>();
            string sql = "SELECT id, NOMBRE, TELEFONO, UID, HORA_ENTRADA, HORA_SALIDA FROM invitados ";

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                sql += "WHERE NOMBRE LIKE @filtro OR TELEFONO LIKE @filtro OR UID LIKE @filtro ";
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

        public Invitado? BuscarPorUid(string uid)
        {
            const string sql = "SELECT id, NOMBRE, TELEFONO, UID, HORA_ENTRADA, HORA_SALIDA " +
                               "FROM invitados WHERE UID = @uid LIMIT 1";

            using MySqlConnection conexion = ConnectionFactory.CrearConexion();
            conexion.Open();

            using var comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@uid", uid);

            using MySqlDataReader reader = comando.ExecuteReader();
            return reader.Read() ? Mapear(reader) : null;
        }

        /// <summary>
        /// Registra la hora de entrada de un invitado por su UID y limpia
        /// su hora de salida previa. Devuelve false si el UID no existe
        /// en la tabla (0 filas afectadas) o si hubo un error de BD.
        /// </summary>
        public bool RegistrarEntrada(string uid)
        {
            string fechaHoraMySQL = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Usamos NULL en vez de '' para columnas DATETIME.
            const string sql = "UPDATE invitados SET HORA_ENTRADA = @hora, HORA_SALIDA = NULL WHERE TRIM(UID) = @uid";

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
                Console.WriteLine("Error al registrar entrada de invitado: " + ex.Message);
                return false;
            }
        }

        public bool RegistrarSalida(string uid)
        {
            string fechaHoraMySQL = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            const string sql = "UPDATE invitados SET HORA_SALIDA = @hora WHERE TRIM(UID) = @uid";

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
                Console.WriteLine("Error al registrar salida de invitado: " + ex.Message);
                return false;
            }
        }

        public bool Insertar(Invitado invitado)
        {
            const string sql = "INSERT INTO invitados (NOMBRE, TELEFONO, UID) VALUES (@nombre, @telefono, @uid)";
            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();
                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", invitado.Nombre);
                comando.Parameters.AddWithValue("@telefono", invitado.Telefono);
                comando.Parameters.AddWithValue("@uid", invitado.Uid);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar invitado: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM invitados WHERE id = @id";
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
                Console.WriteLine("Error al eliminar invitado: " + ex.Message);
                return false;
            }
        }

        private static Invitado Mapear(MySqlDataReader reader)
        {
            return new Invitado
            {
                Id = reader.GetInt32("id"),
                Nombre = reader["NOMBRE"].ToString() ?? string.Empty,
                Telefono = reader["TELEFONO"].ToString() ?? string.Empty,
                Uid = reader["UID"].ToString() ?? string.Empty,
                HoraEntrada = reader["HORA_ENTRADA"].ToString() ?? string.Empty,
                HoraSalida = reader["HORA_SALIDA"].ToString() ?? string.Empty,
            };
        }
    }
}
