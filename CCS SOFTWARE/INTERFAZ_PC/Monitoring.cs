using INTERFAZ_PC.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFAZ_PC
{
    public partial class Monitoring : Form
    {
        private SerialPort port;

        private readonly UsuarioRepository _usuarioRepository = new();
        private readonly InvitadoRepository _invitadoRepository = new();

        public Monitoring()
        {
            InitializeComponent();
            // 1. Vinculamos el evento para limpiar memoria y puertos al cerrar la ventana
            this.FormClosing += Monitoring_FormClosing;
            InitializeSerialPort();
        }

        private void btn_guests_Click(object sender, EventArgs e)
        {
            // 1. PRIMERO sueltas el puerto
            LiberarPuertoCOM();
            this.Hide();

            // 2. DESPUÉS abres la nueva ventana
            using (Guests invitados = new Guests())
            {
                invitados.ShowDialog(); // El código se pausa aquí
            } // Al cerrar Guests, se destruye de la memoria

            // 3. AL REGRESAR, vuelves a reconectar
            this.Show();
            InitializeSerialPort();

        }

        private void InitializeSerialPort()
        {
            try
            {
                port = new SerialPort("COM6", 9600); // Ajusta al puerto de tu Arduino
                port.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                port.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con el Arduino en COM6.\nDetalle: {ex.Message}",
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string tarjetaID = port.ReadLine().Trim();

                // Pasamos la ejecución al hilo de la interfaz gráfica
                this.Invoke(new Action(() =>
                {
                    ProcesarEscaneo(tarjetaID);
                }));
            }
            catch (Exception)
            {
                // Ignoramos lecturas sucias o desconexiones abruptas del cable
            }
        }

        /// <summary>
        /// Decide si el UID escaneado pertenece a un usuario o a un
        /// invitado, y si la lectura corresponde a una ENTRADA o una
        /// SALIDA: si la persona no tiene entrada registrada, o ya
        /// había entrado y salido antes, este escaneo cuenta como una
        /// entrada nueva. Si ya está dentro (tiene entrada pero no
        /// salida), este escaneo cuenta como su salida.
        /// </summary>
        private void ProcesarEscaneo(string uid)
        {
            if (string.IsNullOrWhiteSpace(uid)) return;

            try
            {
                // 1. Lógica para USUARIOS
                var usuario = _usuarioRepository.BuscarPorUid(uid);
                if (usuario is not null)
                {
                    bool estaDentro = !string.IsNullOrEmpty(usuario.HoraEntrada) && string.IsNullOrEmpty(usuario.HoraSalida);

                    if (estaDentro)
                    {
                        // -- LLENAMOS LOS TEXTBOX DE SALIDA --
                        label16.Text = usuario.Nombre;
                        label17.Text = usuario.Clave;
                        label18.Text = DateTime.Now.ToString("HH:mm:ss");

                        // Limpiamos los de entrada por estética
                        //LimpiarCamposEntrada();

                        _usuarioRepository.RegistrarSalida(uid);
                       // MessageBox.Show($"Salida registrada: {usuario.Nombre}\n{DateTime.Now:HH:mm:ss}",
                         //   "Monitoreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // -- LLENAMOS LOS TEXTBOX DE ENTRADA --
                        label8.Text = usuario.Nombre;
                        label7.Text = usuario.Clave;
                        label6.Text = DateTime.Now.ToString("HH:mm:ss");

                        // Limpiamos los de salida por estética
                        //LimpiarCamposSalida();

                        _usuarioRepository.RegistrarEntrada(uid);
                        //MessageBox.Show($"Entrada registrada: {usuario.Nombre}\n{DateTime.Now:HH:mm:ss}",
                          //  "Monitoreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                // 2. Lógica para INVITADOS
                var invitado = _invitadoRepository.BuscarPorUid(uid);
                if (invitado is not null)
                {
                    bool estaDentro = !string.IsNullOrEmpty(invitado.HoraEntrada) && string.IsNullOrEmpty(invitado.HoraSalida);

                    if (estaDentro)
                    {
                        // -- LLENAMOS LOS TEXTBOX DE SALIDA --
                        label16.Text = invitado.Nombre;
                        label17.Text = "Visita";
                        label18.Text = DateTime.Now.ToString("HH:mm:ss");


                        //LimpiarCamposEntrada();

                        _invitadoRepository.RegistrarSalida(uid);
                        //MessageBox.Show($"Salida registrada (invitado): {invitado.Nombre}\n{DateTime.Now:HH:mm:ss}",
                          //  "Monitoreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // -- LLENAMOS LOS TEXTBOX DE ENTRADA --
                        label8.Text = invitado.Nombre;
                        label7.Text = "Visita";
                        label6.Text = DateTime.Now.ToString("HH:mm:ss");

                        //LimpiarCamposSalida();

                        _invitadoRepository.RegistrarEntrada(uid);
                        //MessageBox.Show($"Entrada registrada (invitado): {invitado.Nombre}\n{DateTime.Now:HH:mm:ss}",
                           // "Monitoreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                MessageBox.Show($"Tarjeta no reconocida: {uid}", "Monitoreo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el escaneo: " + ex.Message, "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_reports_Click(object sender, EventArgs e)
        {
            // Mismo patrón que btn_guests_Click: se suelta el puerto,
            // se abre GReport como diálogo modal (se destruye solo al
            // cerrarse, sin dejar una instancia fantasma oculta) y al
            // volver se reconecta el puerto.
            LiberarPuertoCOM();
            this.Hide();

            using (GReport reportes = new GReport())
            {
                reportes.ShowDialog();
            }

            this.Show();
            InitializeSerialPort();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Monitoring_Load(object sender, EventArgs e)
        {

        }

        private void LiberarPuertoCOM()
        {
            try
            {
                if (port != null && port.IsOpen)
                {
                    port.Close();
                    port.Dispose();
                }
            }
            catch (Exception) { /* Ignorar errores al forzar el cierre */ }
        }

        // --- LIMPIEZA CRÍTICA ---
        private void Monitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reutilizamos el método para liberar el puerto cuando el usuario presiona la 'X'
            LiberarPuertoCOM();

            // Si Monitoring es tu ventana principal, descomenta esta línea para asegurar
            // que todas las ventanas ocultas también se destruyan y el programa se apague por completo.
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
