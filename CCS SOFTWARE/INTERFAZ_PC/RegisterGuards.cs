using INTERFAZ_PC.Models;
using INTERFAZ_PC.Repositories;
using INTERFAZ_PC.Security;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace INTERFAZ_PC
{
    public partial class RegisterGuards : Form
    {
        private readonly GuardiaRepository _guardiaRepository = new();
        private SerialPort port;

        public RegisterGuards()
        {
            InitializeComponent();
            InitializeSerialPort();
            this.FormClosing += registerGuards_FormClosing;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // RegisterGuards ahora siempre se abre como diálogo modal
            // desde Guards (ver Guards.button3_Click), así que "volver"
            // es simplemente cerrarse: el control regresa solo a Guards,
            // sin crear una segunda instancia que compita por el puerto
            // COM6 que este formulario tiene abierto.
            this.Close();
        }

        private void RegisterGuards_Load(object sender, EventArgs e)
        {
        }

        private void btn_Guards_Click(object sender, EventArgs e)
        {
            // Mismo criterio que button7_Click: este formulario solo
            // sabe volver a quien lo abrió (Guards). Para ir a Ausers o
            // AReport, cierra este diálogo primero desde Guards.
            this.Close();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // La contraseña capturada (txt_passwordguard) se hashea antes
            // de guardarse: nunca se escribe texto plano en la base de datos.
            var nuevoGuardia = new Guardia
            {
                Nombre = txt_guardname.Text,
                Domicilio = txt_adressguard.Text,
                Telefono = txt_phoneguard.Text,
                Correo = txt_mailguard.Text,
                Usuario = txt_aliasguard.Text,
                Clave = PasswordHasher.Hash(txt_passwordguard.Text),
                Uid = txt_uid.Text,
            };

            bool guardado = _guardiaRepository.Insertar(nuevoGuardia);

            if (guardado)
            {
                MessageBox.Show("Registro Guardado");

                txt_adressguard.Text = "";
                txt_aliasguard.Text = "";
                txt_ID.Text = "";
                txt_mailguard.Text = "";
                txt_phoneguard.Text = "";
                txt_passwordguard.Text = "";
                txt_guardname.Text = "";
                txt_uid.Text = "";
            }
            else
            {
                MessageBox.Show("Error al guardar el registro. Revisa la conexión a la base de datos.");
            }
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
                    label12.Text = tarjetaID;

                    // Opcional: Aviso visual
                    MessageBox.Show("¡Tarjeta escaneada con éxito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception) { /* Ignorar lecturas sucias */ }
        }

        private void registerGuards_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
