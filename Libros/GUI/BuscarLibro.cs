using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros.GUI
{
    public partial class BuscarLibro : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.BUSCAR_LIBRO();
                Filtrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void Filtrar()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "titulo LIKE '%" + txbFiltro.Text + "%' OR categoria LIKE '%" + txbFiltro.Text + "%' OR autor LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgBuscarLibros.AutoGenerateColumns = false;
                dtgBuscarLibros.DataSource = _DATOS;
                lblRegistros.Text = dtgBuscarLibros.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public BuscarLibro()
        {
            InitializeComponent();
        }

        private void buscarLibro_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
