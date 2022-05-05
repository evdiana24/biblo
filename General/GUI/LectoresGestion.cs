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
    public partial class LectoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDLectorSeleccionado;
        String _LectorSeleccionado;
        bool _Seleccionado = false;

        public string IDLectorSeleccionado
        {
            get
            {
                return _IDLectorSeleccionado;
            }

            set
            {
                _IDLectorSeleccionado = value;
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

        public LectoresGestion()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_LECTORES();
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
                    _DATOS.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgLectoresGestion.AutoGenerateColumns = false;
                dtgLectoresGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgLectoresGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.LectorEdicion f = new LectorEdicion();
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
                    GUI.LectorEdicion f = new LectorEdicion();
                    f.txbIdLector.Text = dtgLectoresGestion.CurrentRow.Cells["idLector"].Value.ToString();
                    f.txbNombres.Text = dtgLectoresGestion.CurrentRow.Cells["nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgLectoresGestion.CurrentRow.Cells["apellidos"].Value.ToString();
                    f.dtFechaNacimiento.Text = dtgLectoresGestion.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                    f.cmbGenero.Text = dtgLectoresGestion.CurrentRow.Cells["genero"].Value.ToString();
                    f.txbTelefono.Text = dtgLectoresGestion.CurrentRow.Cells["telefono"].Value.ToString();
                    f.txbCorreo.Text = dtgLectoresGestion.CurrentRow.Cells["correo"].Value.ToString();
                    f.txbDireccion.Text = dtgLectoresGestion.CurrentRow.Cells["direccion"].Value.ToString();
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
                    CLS.Lectores oLector = new CLS.Lectores();
                    oLector.IdLector = dtgLectoresGestion.CurrentRow.Cells["idLector"].Value.ToString();
                    if (oLector.Eliminar())
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
                _IDLectorSeleccionado = dtgLectoresGestion.CurrentRow.Cells["idLector"].Value.ToString();
                _LectorSeleccionado = dtgLectoresGestion.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgLectoresGestion.CurrentRow.Cells["apellidos"].Value.ToString();
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

        private void LectoresGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
