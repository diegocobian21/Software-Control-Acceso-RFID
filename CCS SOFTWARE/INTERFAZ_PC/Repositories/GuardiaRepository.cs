using System;
using System.Collections.Generic;
using INTERFAZ_PC.Data;
using INTERFAZ_PC.Models;
using INTERFAZ_PC.Security;
using MySql.Data.MySqlClient;

namespace INTERFAZ_PC.Repositories
{
    /// <summary>
    /// Acceso a datos para la tabla "guardias".
    /// Reemplaza los métodos de guardias que vivían en DBconexion.cs.
    /// </summary>
    public class GuardiaRepository
    {
        public List<Guardia> Buscar(string? filtro)
        {
            var lista = new List<Guardia>();

            string sql = "SELECT id, NOMBRE, DOMICILIO, TELEFONO, CORREO, USUARIO, CONTRASEÑA, UID " +
                         "FROM guardias ";

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                sql += "WHERE NOMBRE LIKE @filtro OR DOMICILIO LIKE @filtro OR TELEFONO LIKE @filtro " +
                       "OR CORREO LIKE @filtro OR USUARIO LIKE @filtro OR UID LIKE @filtro ";
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

        /// <summary>
        /// Inserta un guardia. Clave debe llegar ya hasheada
        /// (usar Security.PasswordHasher.Hash antes de llamar esto).
        /// </summary>
        public bool Insertar(Guardia guardia)
        {
            const string sql = "INSERT INTO guardias (NOMBRE, DOMICILIO, TELEFONO, CORREO, USUARIO, CONTRASEÑA, UID) " +
                                "VALUES (@nombre, @domicilio, @telefono, @correo, @usuario, @clave, @uid)";

            try
            {
                using MySqlConnection conexion = ConnectionFactory.CrearConexion();
                conexion.Open();

                using var comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", guardia.Nombre);
                comando.Parameters.AddWithValue("@domicilio", guardia.Domicilio);
                comando.Parameters.AddWithValue("@telefono", guardia.Telefono);
                comando.Parameters.AddWithValue("@correo", guardia.Correo);
                comando.Parameters.AddWithValue("@usuario", guardia.Usuario);
                comando.Parameters.AddWithValue("@clave", guardia.Clave);
                comando.Parameters.AddWithValue("@uid", guardia.Uid);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar guardia: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM guardias WHERE id = @id";

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
                Console.WriteLine("Error al eliminar guardia: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Valida usuario/contraseña contra la tabla guardias comparando
        /// el hash BCrypt. Reemplaza el "if (usuario == 'Css' ...)"
        /// hardcodeado que había en Login.cs.
        /// </summary>
        public bool ValidarCredenciales(string usuario, string contrasenaPlano)
        {
            const string sql = "SELECT CONTRASEÑA FROM guardias WHERE USUARIO = @usuario LIMIT 1";

            using MySqlConnection conexion = ConnectionFactory.CrearConexion();
            conexion.Open();

            using var comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            object? resultado = comando.ExecuteScalar();
            if (resultado is null)
            {
                return false; // usuario no existe
            }

            string hashGuardado = resultado.ToString() ?? string.Empty;
            return PasswordHasher.Verify(contrasenaPlano, hashGuardado);
        }

        private static Guardia Mapear(MySqlDataReader reader)
        {
            return new Guardia
            {
                Id = reader.GetInt32("id"),
                Nombre = reader["NOMBRE"].ToString() ?? string.Empty,
                Domicilio = reader["DOMICILIO"].ToString() ?? string.Empty,
                Telefono = reader["TELEFONO"].ToString() ?? string.Empty,
                Correo = reader["CORREO"].ToString() ?? string.Empty,
                Usuario = reader["USUARIO"].ToString() ?? string.Empty,
                Clave = reader["CONTRASEÑA"].ToString() ?? string.Empty,
                Uid = reader["UID"].ToString() ?? string.Empty,
            };
        }
    }
}
