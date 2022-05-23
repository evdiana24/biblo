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
            dtHasta.Value = dtHasta.Value.AddDays(1);
            dtDesde.Value = dtDesde.Value.AddMonths(-1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtDesde.Value.Date > dtHasta.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _DATOS.Filter = "fecha_prestamo >= '" + dtDesde.Value.Date + "' and  fecha_prestamo <= '" +
                dtHasta.Value.Date + "'";
            }
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtDesde.Value.Date > dtHasta.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _DATOS.Filter = "fecha_prestamo >= '" + dtDesde.Value.Date + "' and  fecha_prestamo <= '" +
                dtHasta.Value.Date + "'";
            }
        }
    }
}
