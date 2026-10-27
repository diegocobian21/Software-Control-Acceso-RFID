using BCrypt.Net;

namespace INTERFAZ_PC.Security
{
    /// <summary>
    /// Centraliza el hashing de contraseñas. Nadie fuera de esta clase
    /// debería manejar contraseñas en texto plano más allá del
    /// formulario donde el usuario las captura.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Genera un hash BCrypt (con salt incluido) a partir de una
        /// contraseña en texto plano. Esto es lo que se guarda en BD.
        /// </summary>
        public static string Hash(string plainTextPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainTextPassword);
        }

        /// <summary>
        /// Compara una contraseña en texto plano (la que el usuario
        /// escribe al iniciar sesión) contra el hash guardado en BD.
        /// </summary>
        public static bool Verify(string plainTextPassword, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(storedHash))
            {
                return false;
            }

            try
            {
                return BCrypt.Net.BCrypt.Verify(plainTextPassword, storedHash);
            }
            catch (SaltParseException)
            {
                // El valor guardado no es un hash BCrypt válido
                // (por ejemplo, datos viejos en texto plano).
                return false;
            }
        }
    }
}
