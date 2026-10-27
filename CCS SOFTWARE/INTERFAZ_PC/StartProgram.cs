using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace INTERFAZ_PC
{

    public partial class StartProgram : Form
    {

        public StartProgram()
        {
            InitializeComponent();


            // Inicializar el ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 25;


            this.timer1.Start();


        }

        private void StartProgram_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                // Validar la conexión a la base de datos
                if (INTERFAZ_PC.Data.ConnectionFactory.ValidarConexion())
                {

                    // Cerrar la pantalla de carga
                    Login sesion = new Login();
                    sesion.Show();
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    // Mostrar un mensaje de error
                    MessageBox.Show("Error al conectar la base de datos");

                    // Detener el Timer
                    timer1.Stop();

                    // Cerrar la aplicación
                    Application.Exit();
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }

}

