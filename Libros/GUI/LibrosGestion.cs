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
            catch (Exception)
            {

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
                _IDLibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["tID"].Value.ToString();
                _LibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["tTitulo"].Value.ToString();
                _Seleccionado = true;
                Close();
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
                    oLibro.IdLibro = dtgLibrosGestion.CurrentRow.Cells["tID"].Value.ToString();
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
            /*try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.LibroEdicion f = new LibroEdicion();
                    f.txbIdLibro.Text = dtgLibrosGestion.CurrentRow.Cells["tID"].Value.ToString();
                    f.txbNombres.Text = dtgDatos.CurrentRow.Cells["tTitulo"].Value.ToString();
                    f.txbApellidos.Text = dtgDatos.CurrentRow.Cells["tEditorial"].Value.ToString();
                    f.cbbGenero.Text = dtgDatos.CurrentRow.Cells["Genero"].Value.ToString();
                    f.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
