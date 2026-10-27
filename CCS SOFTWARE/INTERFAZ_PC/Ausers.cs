using System;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;
using INTERFAZ_PC.Repositories;

namespace INTERFAZ_PC
{
    public partial class Ausers : Form
    {
        private readonly UsuarioRepository _usuarioRepository = new();

        private void Ausers_Load_2(object sender, EventArgs e)
        {

        }

        public Ausers()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // RegisterUsers usa el puerto COM6 para leer la tarjeta NFC
            // del nuevo usuario, así que se abre como diálogo modal:
            // Ausers no usa el puerto, así que se queda abierto detrás
            // sin ningún conflicto, y al cerrar el diálogo refrescamos
            // la tabla por si se guardó un registro nuevo.
            using (RegisterUsers registro = new RegisterUsers())
            {
                registro.ShowDialog();
            }

            cargarTabla(null);
        }

        private void btn_Guards_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Guards());
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new AReport());
        }

        private void Ausers_Load(object sender, EventArgs e)
        {

        }

        private void Ausers_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dato = txt_searcher.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            dataGridView1.DataSource = _usuarioRepository.Buscar(dato);
        }

        private void txt_searcher_Click(object sender, EventArgs e)
        {
            txt_searcher.Text = "";
        }

        private void txt_searcher_Leave_1(object sender, EventArgs e)
        {
            

            //if (txt_searcher.Text != " ")
            //{
            //    txt_searcher.Text = " Buscador ";

            //}
        }

        private void txt_searcher_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string dato;
        //    txt_searcher.Text = "";
        //    dato = txt_searcher.Text;
        //    cargarTabla(dato);

        //}

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            int id;
           

            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                bandera = _usuarioRepository.Eliminar(id);
            }

            if(bandera)
            {
                MessageBox.Show("Registro eliminado");
                cargarTabla(null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }


    }
}
