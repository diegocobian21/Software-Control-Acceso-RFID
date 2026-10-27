using System;
using System.Drawing;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;

namespace INTERFAZ_PC
{
    public partial class Initiation_Admin : Form
    {
        public Initiation_Admin()
        {
            InitializeComponent();
        }

        private void Initiation_Admin_Load(object sender, EventArgs e)
        {

        }

        private void lb_CSSMark_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Guards_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Guards());
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Ausers());
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new AReport());
        }


    }
}
