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
    public partial class DevolucionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_DEVOLUCIONES();
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
                dtgDevolucionesGestion.AutoGenerateColumns = false;
                dtgDevolucionesGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgDevolucionesGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public DevolucionesGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.DevolucionEdicion f = new DevolucionEdicion();
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
                    GUI.DevolucionEdicion f = new DevolucionEdicion();
                    f.txbIdDevolucion.Text = dtgDevolucionesGestion.CurrentRow.Cells["idDevolucion"].Value.ToString();
                    f.txbIdDetalle.Text = dtgDevolucionesGestion.CurrentRow.Cells["idDetalle"].Value.ToString();
                    f.cmbCondicion.Text = dtgDevolucionesGestion.CurrentRow.Cells["condicion_libro"].Value.ToString();
                    f.txbDescripcion.Text = dtgDevolucionesGestion.CurrentRow.Cells["descripcion"].Value.ToString();
                    f.dtFechaEntregado.Text = dtgDevolucionesGestion.CurrentRow.Cells["fecha_entregado"].Value.ToString();
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
                    CLS.Devoluciones oDevolucion = new CLS.Devoluciones();
                    oDevolucion.IdDevolucion = dtgDevolucionesGestion.CurrentRow.Cells["idDevolucion"].Value.ToString();
                    if (oDevolucion.Eliminar())
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
