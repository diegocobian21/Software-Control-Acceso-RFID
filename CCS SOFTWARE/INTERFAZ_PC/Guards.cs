using System;
using System.Windows.Forms;
using INTERFAZ_PC.Navigation;
using INTERFAZ_PC.Repositories;

namespace INTERFAZ_PC
{
    public partial class Guards : Form
    {
        private readonly GuardiaRepository _guardiaRepository = new();

        public Guards()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // RegisterGuards usa el puerto COM6, así que se abre como
            // diálogo modal: Guards no usa el puerto, se queda abierto
            // detrás sin conflicto, y al cerrar el diálogo refrescamos
            // la tabla por si se guardó un registro nuevo.
            using (RegisterGuards registro = new RegisterGuards())
            {
                registro.ShowDialog();
            }

            cargarTabla(null);
        }

        private void Guards_Load(object sender, EventArgs e)
        {

        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new Ausers());
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            FormNavigator.NavegarA(this, new AReport());
        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txt_searcher_Click(object sender, EventArgs e)
        {
            txt_searcher.Text = "";
        }

        private void cargarTabla(string dato)
        {
            dataGridView1.DataSource = _guardiaRepository.Buscar(dato);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dato = txt_searcher.Text;
            cargarTabla(dato);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            int id;


            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {

                id = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                bandera = _guardiaRepository.Eliminar(id);
            }

            if (bandera)
            {
                MessageBox.Show("Registro eliminado");
                cargarTabla(null);
            }
        }

        private void txt_searcher_TextChanged(object sender, EventArgs e)
        {

        }
    }
  }

