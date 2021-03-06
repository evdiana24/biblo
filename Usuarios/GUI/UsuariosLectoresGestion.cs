using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.GUI
{
    public partial class UsuariosLectoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDUsuarioSeleccionado;
        String _UsuarioSeleccionado;
        bool _Seleccionado = false;

        public string IDUsuarioSeleccionado
        {
            get
            {
                return _IDUsuarioSeleccionado;
            }

            set
            {
                _IDUsuarioSeleccionado = value;
            }
        }

        public string UsuarioSeleccionado
        {
            get
            {
                return _UsuarioSeleccionado;
            }

            set
            {
                _UsuarioSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_USUARIOS_LECTORES();
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
                    _DATOS.Filter = "usuario LIKE '%" + txbFiltro.Text + "%' OR nombre LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgUsuariosGestion.AutoGenerateColumns = false;
                dtgUsuariosGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgUsuariosGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public UsuariosLectoresGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.UsuarioLectorEdicion f = new UsuarioLectorEdicion();
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
                    GUI.UsuarioLectorEdicion f = new UsuarioLectorEdicion();
                    f.txbIdUsuario.Text = dtgUsuariosGestion.CurrentRow.Cells["idUsuario"].Value.ToString();
                    f.txbUsuario.Text = dtgUsuariosGestion.CurrentRow.Cells["usuario"].Value.ToString();
                    f.cmbEstado.Text = dtgUsuariosGestion.CurrentRow.Cells["estado"].Value.ToString();
                    f.cmbCarnet.Text = dtgUsuariosGestion.CurrentRow.Cells["carnet"].Value.ToString();
                    f.dtFechaCreacion.Text = dtgUsuariosGestion.CurrentRow.Cells["fecha_creacion"].Value.ToString();
                    f.txbIdLector.Text = dtgUsuariosGestion.CurrentRow.Cells["idLector"].Value.ToString();
                    f.txbLector.Text = dtgUsuariosGestion.CurrentRow.Cells["nombre"].Value.ToString();
                    //f.txbIdRol.Text = dtgUsuariosGestion.CurrentRow.Cells["idRol"].Value.ToString();
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
                    CLS.UsuariosLectores oUsuario = new CLS.UsuariosLectores();
                    oUsuario.IDUsuario = dtgUsuariosGestion.CurrentRow.Cells["idUsuario"].Value.ToString();
                    if (oUsuario.Eliminar())
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
                _IDUsuarioSeleccionado = dtgUsuariosGestion.CurrentRow.Cells["idUsuario"].Value.ToString();
                _UsuarioSeleccionado = dtgUsuariosGestion.CurrentRow.Cells["usuario"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void UsuariosLectoresGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
