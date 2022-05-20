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
    public partial class DetallesPrestamosVista : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDDetalleSeleccionado;
        String _LectorSeleccionado;
        String _TituloSeleccionado;
        bool _Seleccionado = false;

        public string IDDetalleSeleccionado
        {
            get
            {
                return _IDDetalleSeleccionado;
            }

            set
            {
                _IDDetalleSeleccionado = value;
            }
        }

        public string LectorSeleccionado
        {
            get
            {
                return _LectorSeleccionado;
            }

            set
            {
                _LectorSeleccionado = value;
            }
        }

        public string TituloSeleccionado
        {
            get
            {
                return _TituloSeleccionado;
            }

            set
            {
                _TituloSeleccionado = value;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
            }

            set
            {
                _Seleccionado = value;
            }
        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_DETALLES_PRESTAMOS();
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
                    _DATOS.Filter = "lector LIKE '%" + txbFiltro.Text + "%' OR titulo LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDetallesPrestamos.AutoGenerateColumns = false;
                dtgDetallesPrestamos.DataSource = _DATOS;
                lblRegistros.Text = dtgDetallesPrestamos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public DetallesPrestamosVista()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDDetalleSeleccionado = dtgDetallesPrestamos.CurrentRow.Cells["idDetalle"].Value.ToString();
                _TituloSeleccionado = dtgDetallesPrestamos.CurrentRow.Cells["titulo"].Value.ToString();
                _LectorSeleccionado = dtgDetallesPrestamos.CurrentRow.Cells["lector"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void PrestamosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dtDesde.Value = dtDesde.Value.AddMonths(-1);
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
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
