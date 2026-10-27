using System;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;
using INTERFAZ_PC.Repositories;

namespace INTERFAZ_PC
{
    public partial class Login : Form
    {
        private readonly GuardiaRepository _guardiaRepository = new();
        private readonly AdministradorRepository _administradorRepository = new();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_User.Text.Trim();
            string contrasena = txt_password.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_administradorRepository.ValidarCredenciales(usuario, contrasena))
                {
                    FormNavigator.NavegarA(this, new Initiation_Admin());
                    return;
                }

                if (_guardiaRepository.ValidarCredenciales(usuario, contrasena))
                {
                    FormNavigator.NavegarA(this, new Initiation_Guards());
                    return;
                }

                MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo validar el login: " + ex.Message, "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
