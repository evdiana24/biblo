using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EditorialesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDEditorialSeleccionado;
        String _EditorialSeleccionado;
        bool _Seleccionado = false;

        public string IDEditorialSeleccionado
        {
            get
            {
                return _IDEditorialSeleccionado;
            }

            set
            {
                _IDEditorialSeleccionado = value;
            }
        }

        public string EditorialSeleccionado
        {
            get
            {
                return _EditorialSeleccionado;
            }

            set
            {
                _EditorialSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_EDITORIALES();
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
                    _DATOS.Filter = "editorial LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgEditorialesGestion.AutoGenerateColumns = false;
                dtgEditorialesGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgEditorialesGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public EditorialesGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.EditorialEdicion f = new EditorialEdicion();
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
                    GUI.EditorialEdicion f = new EditorialEdicion();
                    f.txbIdEditorial.Text = dtgEditorialesGestion.CurrentRow.Cells["idEditorial"].Value.ToString();
                    f.txbEditorial.Text = dtgEditorialesGestion.CurrentRow.Cells["editorial"].Value.ToString();
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
                    CLS.Editoriales oEditorial = new CLS.Editoriales();
                    oEditorial.IDEditorial = dtgEditorialesGestion.CurrentRow.Cells["idEditorial"].Value.ToString();
                    if (oEditorial.Eliminar())
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDEditorialSeleccionado = dtgEditorialesGestion.CurrentRow.Cells["idEditorial"].Value.ToString();
                _EditorialSeleccionado = dtgEditorialesGestion.CurrentRow.Cells["editorial"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void EditorialesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
