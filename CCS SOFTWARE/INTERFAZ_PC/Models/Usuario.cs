namespace INTERFAZ_PC.Models
{
    /// <summary>
    /// Representa un registro de la tabla "usuarios".
    /// Reemplaza el uso de List&lt;object&gt; + casteo manual.
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;

        /// <summary>
        /// Hash de la contraseña (BCrypt). Nunca se guarda ni se muestra en texto plano.
        /// Se llama "Clave" (no "ClaveHash") porque así coincide con el
        /// DataPropertyName ya configurado en el DataGridView del diseñador.
        /// </summary>
        public string Clave { get; set; } = string.Empty;

        public string Horario { get; set; } = string.Empty;
        public string Ocupacion { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
        public string Uid { get; set; } = string.Empty;

        public string HoraEntrada { get; set; } = string.Empty;

        public string HoraSalida { get; set; } = string.Empty;
    }
}
