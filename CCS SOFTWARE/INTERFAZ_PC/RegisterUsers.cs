using INTERFAZ_PC.Models;
using INTERFAZ_PC.Repositories;
using INTERFAZ_PC.Security;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace INTERFAZ_PC
{
    public partial class RegisterUsers : Form
    {
        private string _carreraSeleccionada = string.Empty;
        private readonly UsuarioRepository _usuarioRepository = new();
        private SerialPort port;

        public RegisterUsers()
        {
            InitializeComponent();
            InitializeSerialPort();
            txt_Area_User.Visible = false;
            txt_carrera_User.Visible = false;
            cb_area_User.Visible = false;
            cb_ing_agro.Visible = false;
            cb_ing_compu.Visible = false;
            cb_ing_cienciaTierra.Visible = false;
            cb_ing_civil.Visible = false;
            cb_ing_AME.Visible = false;
            cb_ing_metalurgia_materiales.Visible = false;
            this.FormClosing += registerUser_FormClosing;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // RegisterUsers ahora siempre se abre como diálogo modal
            // desde Ausers (ver Ausers.button3_Click), así que "volver"
            // es simplemente cerrarse: el control regresa solo a Ausers,
            // sin crear una segunda instancia que compita por el puerto
            // COM6 que este formulario tiene abierto.
            this.Close();
        }

        private void RegisterUsers_Load(object sender, EventArgs e)
        {
        }

        private void cb_ocp_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ocp_User.SelectedIndex == 0)
            {
                txt_Area_User.Visible = true;
                cb_area_User.Visible = true;
            }
            else
            {
                txt_Area_User.Visible = false;
                txt_carrera_User.Visible = false;
                cb_area_User.Visible = false;
            }
        }

        private void cb_area_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_area_User.SelectedIndex == 0)
            {
                txt_carrera_User.Visible = true;
                cb_ing_agro.Visible = true;

                cb_ing_compu.Visible = false;
            }
            else if (cb_area_User.SelectedIndex == 1)
            {
                txt_carrera_User.Visible = true;
                cb_ing_compu.Visible = true;

                cb_ing_agro.Visible = false;
            }
            else if (cb_area_User.SelectedIndex == 2)
            {
                txt_carrera_User.Visible = true;
                cb_ing_cienciaTierra.Visible = true;

                cb_ing_compu.Visible = false;
                cb_ing_agro.Visible = false;
            }
            else if (cb_area_User.SelectedIndex == 3)
            {
                txt_carrera_User.Visible = true;
                cb_ing_civil.Visible = true;

                cb_ing_compu.Visible = false;
                cb_ing_agro.Visible = false;
                cb_ing_cienciaTierra.Visible = false;
            }
            else if (cb_area_User.SelectedIndex == 4)
            {
                txt_carrera_User.Visible = true;
                cb_ing_AME.Visible = true;

                cb_ing_compu.Visible = false;
                cb_ing_agro.Visible = false;
                cb_ing_cienciaTierra.Visible = false;
                cb_ing_civil.Visible = false;
            }
            else if (cb_area_User.SelectedIndex == 5)
            {
                txt_carrera_User.Visible = true;
                cb_ing_metalurgia_materiales.Visible = true;

                cb_ing_compu.Visible = false;
                cb_ing_agro.Visible = false;
                cb_ing_cienciaTierra.Visible = false;
                cb_ing_civil.Visible = false;
                cb_ing_AME.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) //boton guardar
        {
            if (cb_ing_agro.Visible)
            {
                _carreraSeleccionada = cb_ing_agro.Text;
            }
            else if (cb_ing_compu.Visible)
            {
                _carreraSeleccionada = cb_ing_compu.Text;
            }
            else if (cb_ing_civil.Visible)
            {
                _carreraSeleccionada = cb_ing_civil.Text;
            }
            else if (cb_ing_metalurgia_materiales.Visible)
            {
                _carreraSeleccionada = cb_ing_metalurgia_materiales.Text;
            }
            else if (cb_ing_cienciaTierra.Visible)
            {
                _carreraSeleccionada = cb_ing_cienciaTierra.Text;
            }
            else if (cb_ing_AME.Visible)
            {
                _carreraSeleccionada = cb_ing_AME.Text;
            }

            
            var nuevoUsuario = new Usuario
            {
                Nombre = txt_nameUser.Text,
                Telefono = txt_phoneUser.Text,
                Correo = txt_mailUser.Text,
                Clave = txt_codeUser.Text,
                Horario = txt_scheduleUser.Text,
                Ocupacion = cb_ocp_User.Text,
                Area = cb_area_User.Text,
                Carrera = _carreraSeleccionada,
                Uid = txt_uid.Text,
            };

            bool guardado = _usuarioRepository.Insertar(nuevoUsuario);

            if (guardado)
            {
                MessageBox.Show("Registro Guardado");

                cb_ing_agro.Visible = false;
                cb_ing_agro.Items.Clear();

                cb_ing_compu.Visible = false;
                cb_ing_compu.Items.Clear();

                cb_ing_cienciaTierra.Visible = false;
                cb_ing_cienciaTierra.Items.Clear();

                cb_ing_civil.Visible = false;
                cb_ing_civil.Items.Clear();

                cb_ing_AME.Visible = false;
                cb_ing_AME.Items.Clear();

                cb_ing_metalurgia_materiales.Visible = false;
                cb_ing_metalurgia_materiales.Items.Clear();

                txt_Area_User.Visible = false;
                txt_carrera_User.Visible = false;
                cb_area_User.Visible = false;

                txt_nameUser.Text = "";
                txt_phoneUser.Text = "";
                txt_mailUser.Text = "";
                txt_codeUser.Text = "";
                txt_scheduleUser.Text = "";
                txt_uid.Text = "";
                cb_ocp_User.Text = "";
                cb_area_User.Text = "";

                _carreraSeleccionada = string.Empty;
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

        private void registerUser_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Guards_Click(object sender, EventArgs e)
        {
            // Mismo criterio que button7_Click: este formulario solo
            // sabe volver a quien lo abrió (Ausers). Para ir a Guards o
            // AReport, cierra este diálogo primero desde Ausers.
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


    }
}
