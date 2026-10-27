using System;
using System.Windows.Forms;

namespace INTERFAZ_PC
{
    public partial class GReport : Form
    {
        public GReport()
        {
            InitializeComponent();
        }

        private void btn_monitoring_Click(object sender, EventArgs e)
        {
            // GReport ahora siempre se abre como diálogo modal desde
            // Monitoring (ver Monitoring.btn_reports_Click), así que
            // "volver" es simplemente cerrarse: el control regresa solo
            // a quien lo abrió, sin crear una segunda instancia de
            // Monitoring (que intentaría abrir el puerto COM6 otra vez).
            this.Close();
        }

        private void btn_guests_Click(object sender, EventArgs e)
        {
            using (Guests invitados = new Guests())
            {
                invitados.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
   
        }


    }
}
