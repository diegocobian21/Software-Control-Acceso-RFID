using System.Windows.Forms;

namespace INTERFAZ_PC.Navigation
{
    /// <summary>
    /// Navegación entre pantallas que SÍ libera memoria.
    ///
    /// El patrón viejo ("nuevaForma.Show(); this.Hide();") nunca destruye
    /// la ventana anterior: se queda oculta y viva en memoria para
    /// siempre. Si navegas de ida y vuelta entre pantallas muchas veces
    /// (por ejemplo Ausers → Guards → Ausers → Guards...), cada vez se
    /// crea una ventana nueva y las viejas se van acumulando ocultas —
    /// eso es la "ventana fantasma" que ibas acumulando.
    ///
    /// NavegarA hace lo mismo que antes para quien lo usa (abre la
    /// siguiente pantalla), pero además CIERRA la actual con Close(),
    /// que en WinForms dispara Dispose() y libera sus recursos de
    /// verdad, en vez de solo ocultarla.
    ///
    /// OJO: esto es solo para pantallas que NO usan el puerto COM6
    /// (Login, los menús, Ausers, Guards, AReport, GReport,
    /// Initiation_Admin, Initiation_Guards al entrar a Monitoring).
    ///
    /// Las 4 pantallas que SÍ usan el puerto COM6 (Guests, Monitoring,
    /// RegisterGuards, RegisterUsers) NUNCA se abren con NavegarA: se
    /// abren siempre como diálogo modal (ShowDialog) desde una pantalla
    /// que no usa el puerto, y su propio botón de "volver" solo hace
    /// this.Close() para regresar a quien las abrió. Así nunca hay dos
    /// formularios compitiendo por el mismo puerto COM6, y tampoco se
    /// corre el riesgo de cerrar la pantalla que las abrió y quedarse
    /// sin ninguna ventana visible. Ver Ausers.button3_Click,
    /// Guards.button3_Click, Initiation_Guards.btn_guests_Click/
    /// btn_report_Click y Monitoring.btn_guests_Click/btn_reports_Click
    /// para el patrón exacto.
    ///
    /// Tampoco se usa para StartProgram (es la ventana raíz original de
    /// Application.Run: cerrarla cerraría toda la app).
    /// </summary>
    public static class FormNavigator
    {
        public static void NavegarA(Form formularioActual, Form formularioDestino)
        {
            formularioDestino.Show();
            formularioActual.Close();
        }
    }
}
