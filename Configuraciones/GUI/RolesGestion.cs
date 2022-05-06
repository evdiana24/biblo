using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuraciones.GUI
{
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDRolSeleccionado;
        String _RolSeleccionado;
        bool _Seleccionado = false;

        public string IDRolSeleccionado
        {
            get
            {
                return _IDRolSeleccionado;
            }

            set
            {
                _IDRolSeleccionado = value;
            }
        }

        public string RolSeleccionado
        {
            get
            {
                return _RolSeleccionado;
            }

            set
            {
                _RolSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_ROLES();
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
                    _DATOS.Filter = "rol LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgRolesGestion.AutoGenerateColumns = false;
                dtgRolesGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgRolesGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public RolesGestion()
        {
            InitializeComponent();
        }

        private void verCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.RolesEdicion f = new RolesEdicion();
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
                    GUI.RolesEdicion f = new RolesEdicion();
                    f.txbIdRol.Text = dtgRolesGestion.CurrentRow.Cells["idRol"].Value.ToString();
                    f.txbRol.Text = dtgRolesGestion.CurrentRow.Cells["rol"].Value.ToString();
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
                    CLS.Roles oRol = new CLS.Roles();
                    oRol.IdRol = dtgRolesGestion.CurrentRow.Cells["idRol"].Value.ToString();
                    if (oRol.Eliminar())
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
                _IDRolSeleccionado = dtgRolesGestion.CurrentRow.Cells["idRol"].Value.ToString();
                _RolSeleccionado = dtgRolesGestion.CurrentRow.Cells["rol"].Value.ToString();
                Seleccionado = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
