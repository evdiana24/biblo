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
    public partial class AutoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDEAutorSeleccionado;
        String _AutorSeleccionado;
        bool _Seleccionado = false;

        public string IDEAutorSeleccionado
        {
            get
            {
                return _IDEAutorSeleccionado;
            }

            set
            {
                _IDEAutorSeleccionado = value;
            }
        }

        public string AutorSeleccionado
        {
            get
            {
                return _AutorSeleccionado;
            }

            set
            {
                _AutorSeleccionado = value;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_AUTORES();
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
                dtgAutoresGestion.AutoGenerateColumns = false;
                dtgAutoresGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgAutoresGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public AutoresGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.AutorEdicion f = new AutorEdicion();
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
                    GUI.AutorEdicion f = new AutorEdicion();
                    f.txbIdAutor.Text = dtgAutoresGestion.CurrentRow.Cells["idAutor"].Value.ToString();
                    f.txbNombres.Text = dtgAutoresGestion.CurrentRow.Cells["nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgAutoresGestion.CurrentRow.Cells["apellidos"].Value.ToString();
                    f.cmbGenero.Text = dtgAutoresGestion.CurrentRow.Cells["genero"].Value.ToString();
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
                    CLS.Autores oAutor = new CLS.Autores();
                    oAutor.IdAutor = dtgAutoresGestion.CurrentRow.Cells["idAutor"].Value.ToString();
                    if (oAutor.Eliminar())
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
                _IDEAutorSeleccionado = dtgAutoresGestion.CurrentRow.Cells["idAutor"].Value.ToString();
                _AutorSeleccionado = dtgAutoresGestion.CurrentRow.Cells["nombres"].Value.ToString() + " " + dtgAutoresGestion.CurrentRow.Cells["apellidos"].Value.ToString();
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

        private void AutoresGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
