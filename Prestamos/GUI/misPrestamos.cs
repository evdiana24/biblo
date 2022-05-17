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
                //String pFechaInicio = dtDesde.Value.AddMonths(-1).ToString("yyyy/MM/dd");
                //String pFechaFinal = dtHasta.Value.ToString("yyyy/MM/dd");
                //dtDesde.Value = dtDesde.Value.AddMonths(-1);
                _DATOS.DataSource = DataSource.Consultas.MIS_PRESTAMOS(oSesion.IDUsuario, dtDesde.Value.ToString("yyyy/MM/dd"), dtHasta.Value.ToString("yyyy/MM/dd"));
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
                    _DATOS.Filter = "titulo LIKE '%" + label.Text + "%' OR editorial LIKE '%" + label.Text + "%'";
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
            //dtDesde.Value = dtDesde.Value.AddMonths(-1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
