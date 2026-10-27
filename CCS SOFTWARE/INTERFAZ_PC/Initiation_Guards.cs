using System;
using System.Drawing;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;

namespace INTERFAZ_PC
{
    public partial class Initiation_Guards : Form
    {
        public Initiation_Guards()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_monitoring_Click(object sender, EventArgs e)
        {
            // A partir de aquí, Monitoring es la pantalla "base" del
            // guardia: se queda abierta y las pantallas de invitados o
            // reportes se abren como diálogo (ver Monitoring.cs), nunca
            // se vuelve a crear otra instancia de Monitoring.
            FormNavigator.NavegarA(this, new Monitoring());
        }

        private void btn_guests_Click(object sender, EventArgs e)
        {
            // Guests usa el puerto COM6, así que se abre como diálogo
            // modal (igual que hace Monitoring): Initiation_Guards se
            // queda abierto detrás y sigue ahí cuando Guests se cierra,
            // en vez de perderse como pasaba con FormNavigator (que
            // cerraba esta pantalla y no dejaba a dónde "volver").
            using (Guests invitados = new Guests())
            {
                invitados.ShowDialog();
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            // GReport en sí no usa el puerto, pero desde ahí se puede
            // abrir Guests (que sí lo usa), así que se mantiene el mismo
            // patrón modal por consistencia.
            using (GReport reportes = new GReport())
            {
                reportes.ShowDialog();
            }
        }


    }
}
