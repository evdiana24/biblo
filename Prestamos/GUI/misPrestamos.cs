using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.GUI
{
    public partial class misPrestamos : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.MIS_PRESTAMOS(oSesion.IDUsuario);
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
                    _DATOS.Filter = "titulo LIKE '%" + txbFiltro.Text + "%' OR editorial LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgMisPrestamos.AutoGenerateColumns = false;
                dtgMisPrestamos.DataSource = _DATOS;
                lblRegistros.Text = dtgMisPrestamos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public misPrestamos()
        {
            InitializeComponent();
        }

        private void misPrestamos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
