namespace INTERFAZ_PC.Models
{
    /// <summary>
    /// Representa un registro de la tabla "invitados".
    /// </summary>
    public class Invitado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Uid { get; set; } = string.Empty;

        public string HoraEntrada { get; set; } = string.Empty;

        public string HoraSalida { get; set; } = string.Empty;
    }
}
