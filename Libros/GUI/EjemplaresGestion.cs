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
    public partial class EjemplaresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDEjemplarSeleccionado;
        String _EjemplarSeleccionado;
        bool _Seleccionado = false;

        public string IDEjemplarSeleccionado
        {
            get
            {
                return _IDEjemplarSeleccionado;
            }

            set
            {
                _IDEjemplarSeleccionado = value;
            }
        }

        public string EjemplarSeleccionado
        {
            get
            {
                return _EjemplarSeleccionado;
            }

            set
            {
                _EjemplarSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_EJEMPLARES();
                Filtrar();
            }
            catch (Exception e)
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
                    _DATOS.Filter = "titulo LIKE '%" + txbFiltro.Text + "%' OR estado LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgEjemplaresGestion.AutoGenerateColumns = false;
                dtgEjemplaresGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgEjemplaresGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public EjemplaresGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.EjemplarEdicion f = new EjemplarEdicion();
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
                    GUI.EjemplarEdicion f = new EjemplarEdicion();
                    f.txbIdEjemplar.Text = dtgEjemplaresGestion.CurrentRow.Cells["idEjemplar"].Value.ToString();
                    f.txbIdLibro.Text = dtgEjemplaresGestion.CurrentRow.Cells["idLibro"].Value.ToString();
                    f.cmbEstado.Text = dtgEjemplaresGestion.CurrentRow.Cells["estado"].Value.ToString();
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
                    CLS.Ejemplares oEjemplar = new CLS.Ejemplares();
                    oEjemplar.IDEjemplar = dtgEjemplaresGestion.CurrentRow.Cells["idEjemplar"].Value.ToString();
                    if (oEjemplar.Eliminar())
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
                _IDEjemplarSeleccionado = dtgEjemplaresGestion.CurrentRow.Cells["idEjemplar"].Value.ToString();
                _EjemplarSeleccionado = dtgEjemplaresGestion.CurrentRow.Cells["titulo"].Value.ToString();
                _Seleccionado = true;
                //Close();
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

        private void EjemplaresGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
