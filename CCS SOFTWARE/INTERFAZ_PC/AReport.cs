using System;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;

namespace INTERFAZ_PC
{
    public partial class AReport : Form
    {
        public AReport()
        {
            InitializeComponent();
        }

        private void btn_Guards_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Guards());
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Ausers());
        }
    }
}
