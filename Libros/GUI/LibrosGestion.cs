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
    public partial class LibrosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDLibroSeleccionado;
        String _LibroSeleccionado;
        bool _Seleccionado = false;
        
        public string IDLibroSeleccionado
        {
            get
            {
                return _IDLibroSeleccionado;
            }
        }

        public string LibroSeleccionado
        {
            get
            {
                return _LibroSeleccionado;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
            }
        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_LIBROS();
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
                    _DATOS.Filter = "Titulo LIKE '%" + txbFiltro.Text + "%' OR Editorial LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgLibrosGestion.AutoGenerateColumns = false;
                dtgLibrosGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgLibrosGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public LibrosGestion()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDLibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["IDLibro"].Value.ToString();
                _LibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["Titulo"].Value.ToString();
                _Seleccionado = true;
                //Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Libros oLibro = new CLS.Libros();
                    oLibro.IdLibro = dtgLibrosGestion.CurrentRow.Cells["IDLibro"].Value.ToString();
                    if (oLibro.Eliminar())
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.LibroEdicion f = new LibroEdicion();
                    f.txbIdLibro.Text = dtgLibrosGestion.CurrentRow.Cells["IDLibro"].Value.ToString();
                    f.txbTitulo.Text = dtgLibrosGestion.CurrentRow.Cells["Titulo"].Value.ToString();
                    f.txbAnio.Text = dtgLibrosGestion.CurrentRow.Cells["Anio_publicacion"].Value.ToString();
                    f.txbEdicion.Text = dtgLibrosGestion.CurrentRow.Cells["Edicion"].Value.ToString();
                    f.txbIdEditorial.Text = dtgLibrosGestion.CurrentRow.Cells["IDEditorial"].Value.ToString();
                    f.txbEditorial.Text = dtgLibrosGestion.CurrentRow.Cells["Editorial"].Value.ToString();
                    f.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.LibroEdicion f = new LibroEdicion();
                f.ShowDialog();
                CargarDatos();
            }
            catch (Exception)
            {

            }
        }

        private void LibrosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
