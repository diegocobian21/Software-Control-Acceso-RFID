using INTERFAZ_PC.Models;
using INTERFAZ_PC.Repositories;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace INTERFAZ_PC
{
    public partial class Guests : Form
    {
        private readonly InvitadoRepository _invitadoRepository = new();
        private SerialPort port;

        public Guests()
        {
            InitializeComponent();
            this.FormClosing += Guests_FormClosing;
            InitializeSerialPort();
            cargarTabla(null);
        }

        private void btn_monitoring_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            using (GReport reportes = new GReport())
            {
                reportes.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btn_addguest_Click(object sender, EventArgs e)
        {
            var nuevoInvitado = new Invitado
            {
                Nombre = txt_guest.Text,
                Telefono = txt_phoneguest.Text,
                Uid = txt_UID.Text,
            };

            bool guardado = _invitadoRepository.Insertar(nuevoInvitado);

            if (guardado)
            {
                MessageBox.Show("Registro Guardado");

                txt_guest.Text = "";
                txt_phoneguest.Text = "";
                txt_UID.Text = "";

                cargarTabla(null);
            }
            else
            {
                MessageBox.Show("Error al guardar el registro. Revisa la conexión a la base de datos.");
            }
        }

        private void btn_deleteguest_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                
                int id = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                bandera = _invitadoRepository.Eliminar(id);
            }

            if (bandera)
            {
                MessageBox.Show("Registro eliminado");
                cargarTabla(null);
            }
        }

        private void btn_updateguest_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }

        private void cargarTabla(string? dato)
        {
            dataGridView1.DataSource = _invitadoRepository.Buscar(dato);
        }

  

        private void InitializeSerialPort()
        {
            try
            {
                port = new SerialPort("COM6", 9600);
                port.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con el Arduino en COM6.\nDetalle: {ex.Message}",
                                "Error en Guests", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string tarjetaID = port.ReadLine().Trim();

                // Pasamos al hilo de la interfaz gráfica
                this.Invoke(new Action(() =>
                {
                    // En lugar de buscar en MySQL, simplemente ponemos el ID en el TextBox
                    // para que el guardia pueda registrar a la persona.
                    label9.Text = tarjetaID;
                    txt_UID.Text = tarjetaID;

                    // Opcional: Aviso visual
                    MessageBox.Show("¡Tarjeta escaneada con éxito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception) {}
        }


        private void Guests_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (port != null && port.IsOpen)
                {
                    port.Close();
                    port.Dispose();
                }
            }
            catch (Exception) { }
        }

        private void Guests_Load(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
