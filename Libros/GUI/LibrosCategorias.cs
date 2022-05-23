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
    public partial class LibrosCategorias : Form
    {
        BindingSource _DATOS_CATEGORIAS = new BindingSource();
        BindingSource _DATOS_CATEGORIAS_AGREGADAS = new BindingSource();
        String _IDCategoriaSeleccionada;
        String _CategoriaSeleccionada;
        bool _Seleccionado = false;

        public string IDCategoriaSeleccionada
        {
            get
            {
                return _IDCategoriaSeleccionada;
            }

            set
            {
                _IDCategoriaSeleccionada = value;
            }
        }

        public string CategoriaSeleccionada
        {
            get
            {
                return _CategoriaSeleccionada;
            }

            set
            {
                _CategoriaSeleccionada = value;
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

        private void CargarCategorias()
        {
            try
            {
                _DATOS_CATEGORIAS.DataSource = DataSource.Consultas.TODAS_LAS_CATEGORIAS();
                Filtrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void CargarCategoriasAgregadas()
        {
            try
            {
                _DATOS_CATEGORIAS_AGREGADAS.DataSource = DataSource.Consultas.CATEGORIAS_POR_ID_LIBRO(txbIdLibro.Text);
                dtgCategoriasAgregadas.AutoGenerateColumns = false;
                dtgCategoriasAgregadas.DataSource = _DATOS_CATEGORIAS_AGREGADAS;
                lblEstado.Text = dtgCategoriasAgregadas.Rows.Count.ToString() + " Registro(s) Encontrado(s)";
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
                    _DATOS_CATEGORIAS.Filter = "categoria LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS_CATEGORIAS.RemoveFilter();
                }
                dtgCategorias.AutoGenerateColumns = false;
                dtgCategorias.DataSource = _DATOS_CATEGORIAS;
            }
            catch (Exception)
            {

            }
        }

        public LibrosCategorias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrestamosGestiones_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarCategoriasAgregadas();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDCategoriaSeleccionada = dtgCategorias.CurrentRow.Cells["idCategoria"].Value.ToString();
                _CategoriaSeleccionada = dtgCategorias.CurrentRow.Cells["categoria"].Value.ToString();
                _Seleccionado = true;

                txbIdCategoria.Text = IDCategoriaSeleccionada;
                txbCategoria.Text = CategoriaSeleccionada;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }


        private void Procesar()
        {
            try
            {
                //Creamos el objeto entidad
                CLS.LibrosCategorias oDetalle = new CLS.LibrosCategorias();

                //Sincronizar el objeto con la interfaz
                oDetalle.IdLibro = txbIdLibro.Text;
                oDetalle.IdCategoria = txbIdCategoria.Text;

                //Estoy insertando un nuevo registro
                if (oDetalle.Guardar())
                {
                    //Se guardo correctamente
                    MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Close();
                }
                else
                {
                    //No se guardo correctamente
                    MessageBox.Show("El registro no fue agregado. La categoría ya estaba agregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
                CargarCategoriasAgregadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.LibrosCategorias oLibro_categoria = new CLS.LibrosCategorias();
                    oLibro_categoria.IdLibro_Categoria = dtgCategoriasAgregadas.CurrentRow.Cells["idLibro_categoria"].Value.ToString();
                    if (oLibro_categoria.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCategoriasAgregadas();
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
    }
}
