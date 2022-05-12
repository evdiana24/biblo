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
    public partial class PrestamosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDPrestamoSeleccionado;
        bool _Seleccionado = false;

        public string IDPrestamoSeleccionado
        {
            get
            {
                return _IDPrestamoSeleccionado;
            }

            set
            {
                _IDPrestamoSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_PRESTAMOS();
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
                dtgPrestamosGestion.AutoGenerateColumns = false;
                dtgPrestamosGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgPrestamosGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public PrestamosGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.PrestamoEdicion f = new PrestamoEdicion();
                f.ShowDialog();
                CargarDatos();
            }
            catch (Exception)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.DetallesPrestamos f = new DetallesPrestamos();
                    f.txbIdPrestamo.Text = dtgPrestamosGestion.CurrentRow.Cells["idPrestamo"].Value.ToString();
                    f.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Prestamos oPrestamo = new CLS.Prestamos();
                    oPrestamo.IdPrestamo = dtgPrestamosGestion.CurrentRow.Cells["idPrestamo"].Value.ToString();
                    if (oPrestamo.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                _IDPrestamoSeleccionado = dtgPrestamosGestion.CurrentRow.Cells["idPrestamo"].Value.ToString();
                _Seleccionado = true;

                GUI.DetallesPrestamos f = new DetallesPrestamos();
                f.txbIdPrestamo.Text = dtgPrestamosGestion.CurrentRow.Cells["idPrestamo"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void PrestamosGestion_Load(object sender, EventArgs e)
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
