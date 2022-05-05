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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDEmpleadoSeleccionado;
        String _EmpleadoSeleccionado;
        bool _Seleccionado = false;

        public string IDEmpleadoSeleccionado
        {
            get
            {
                return _IDEmpleadoSeleccionado;
            }

            set
            {
                _IDEmpleadoSeleccionado = value;
            }
        }

        public string EmpleadoSeleccionado
        {
            get
            {
                return _EmpleadoSeleccionado;
            }

            set
            {
                _EmpleadoSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_EMPLEADOS();
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
                dtgEmpleadosGestion.AutoGenerateColumns = false;
                dtgEmpleadosGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgEmpleadosGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public EmpleadosGestion()
        {
            InitializeComponent();
        }

        private void dtgBuscarLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.EmpleadoEdicion f = new EmpleadoEdicion();
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
                    GUI.EmpleadoEdicion f = new EmpleadoEdicion();
                    f.txbIdEmpleado.Text = dtgEmpleadosGestion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    f.txbNombres.Text = dtgEmpleadosGestion.CurrentRow.Cells["nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgEmpleadosGestion.CurrentRow.Cells["apellidos"].Value.ToString();
                    f.dtFechaNacimiento.Text = dtgEmpleadosGestion.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                    f.txbDUI.Text = dtgEmpleadosGestion.CurrentRow.Cells["dui"].Value.ToString();
                    f.txbNIT.Text = dtgEmpleadosGestion.CurrentRow.Cells["nit"].Value.ToString();
                    f.cmbGenero.Text = dtgEmpleadosGestion.CurrentRow.Cells["genero"].Value.ToString();
                    f.txbTelefono.Text = dtgEmpleadosGestion.CurrentRow.Cells["telefono"].Value.ToString();
                    f.txbCorreo.Text = dtgEmpleadosGestion.CurrentRow.Cells["correo"].Value.ToString();
                    f.txbDireccion.Text = dtgEmpleadosGestion.CurrentRow.Cells["direccion"].Value.ToString();
                    f.dtFechaContratacion.Text = dtgEmpleadosGestion.CurrentRow.Cells["fecha_contratacion"].Value.ToString();
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
                    CLS.Empleados oEmpleado = new CLS.Empleados();
                    oEmpleado.IdEmpleado = dtgEmpleadosGestion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    if (oEmpleado.Eliminar())
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
                _IDEmpleadoSeleccionado = dtgEmpleadosGestion.CurrentRow.Cells["idEmpleado"].Value.ToString();
                _EmpleadoSeleccionado = dtgEmpleadosGestion.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgEmpleadosGestion.CurrentRow.Cells["apellidos"].Value.ToString();
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

        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
