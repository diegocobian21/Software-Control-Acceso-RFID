namespace INTERFAZ_PC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //string hashTemporal = BCrypt.Net.BCrypt.HashPassword("ArigatoGozaimaz"); // Cambia Admin123 por tu clave real
            //System.Diagnostics.Debug.WriteLine($"\n--- HASH PARA EL ADMIN: {hashTemporal} ---\n");

            // IMPORTANTE: no usamos Application.Run(new Monitoring()) porque eso
            // convierte a Monitoring en el "formulario principal": WinForms cierra
            // TODA la aplicación en cuanto ESE formulario en particular se cierra
            // (con Close(), como hace FormNavigator), sin importar qué otros
            // formularios sigan abiertos. Eso es lo que causaba que la app se
            // cerrara por completo al navegar entre formularios con FormNavigator,
            // en vez de pasar al siguiente.
            //
            // Con un ApplicationContext sin MainForm asignado, cerrar cualquier
            // formulario (incluido Monitoring) ya NO termina la aplicación.
            // La app solo termina cuando algo llama explícitamente a
            // Application.Exit() — que es justo lo que ya hace
            // Monitoring_FormClosing cuando el usuario presiona la 'X'.
            var contexto = new ApplicationContext();
            var formularioInicial = new Ausers();
            formularioInicial.Show();
            Application.Run(contexto);
        }
    }
}