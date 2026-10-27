namespace INTERFAZ_PC.Models
{
    /// <summary>
    /// Representa un registro de la tabla "guardias".
    /// </summary>
    public class Guardia
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;

        /// <summary>
        /// Hash de la contraseña (BCrypt). Nunca se guarda ni se muestra en texto plano.
        /// Se llama "Clave" (no "ClaveHash") porque así coincide con el
        /// DataPropertyName ya configurado en el DataGridView del diseñador.
        /// </summary>
        public string Clave { get; set; } = string.Empty;

        public string Uid { get; set; } = string.Empty;
    }
}
