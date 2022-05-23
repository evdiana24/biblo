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
    public partial class LibrosAutores : Form
    {
        BindingSource _DATOS_AUTORES = new BindingSource();
        BindingSource _DATOS_AUTORES_AGREGADOS = new BindingSource();
        String _IDAutorSeleccionado;
        String _NombreAutorSeleccionado;
        String _ApellidoAutorSeleccionado;
        bool _Seleccionado = false;

        public string IDAutorSeleccionado
        {
            get
            {
                return _IDAutorSeleccionado;
            }

            set
            {
                _IDAutorSeleccionado = value;
            }
        }

        public string NombreAutorSeleccionado
        {
            get
            {
                return _NombreAutorSeleccionado;
            }

            set
            {
                _NombreAutorSeleccionado = value;
            }
        }

        public string ApellidoAutorSeleccionado
        {
            get
            {
                return _ApellidoAutorSeleccionado;
            }

            set
            {
                _ApellidoAutorSeleccionado = value;
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

        private void CargarAutores()
        {
            try
            {
                _DATOS_AUTORES.DataSource = DataSource.Consultas.TODOS_LOS_AUTORES();
                Filtrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void CargarAutoresAgregados()
        {
            try
            {
                _DATOS_AUTORES_AGREGADOS.DataSource = DataSource.Consultas.AUTORES_POR_ID_LIBRO(txbIdLibro.Text);
                dtgAutoresAgregados.AutoGenerateColumns = false;
                dtgAutoresAgregados.DataSource = _DATOS_AUTORES_AGREGADOS;
                lblEstado.Text = dtgAutoresAgregados.Rows.Count.ToString() + " Registro(s) Encontrado(s)";
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
                    _DATOS_AUTORES.Filter = "nombres LIKE '%" + txbFiltro.Text + "%' OR apellidos LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS_AUTORES.RemoveFilter();
                }
                dtgAutores.AutoGenerateColumns = false;
                dtgAutores.DataSource = _DATOS_AUTORES;
            }
            catch (Exception)
            {

            }
        }

        public LibrosAutores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrestamosGestiones_Load(object sender, EventArgs e)
        {
            CargarAutores();
            CargarAutoresAgregados();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDAutorSeleccionado = dtgAutores.CurrentRow.Cells["idAutor"].Value.ToString();
                _NombreAutorSeleccionado = dtgAutores.CurrentRow.Cells["nombres"].Value.ToString();
                _ApellidoAutorSeleccionado = dtgAutores.CurrentRow.Cells["apellidos"].Value.ToString();
                _Seleccionado = true;

                txbIdAutor.Text = IDAutorSeleccionado;
                txbAutor.Text = NombreAutorSeleccionado + " " + ApellidoAutorSeleccionado;
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
                CLS.LibrosAutores oDetalle = new CLS.LibrosAutores();

                //Sincronizar el objeto con la interfaz
                oDetalle.IdLibro = txbIdLibro.Text;
                oDetalle.IdAutor = txbIdAutor.Text;

                //Estoy insertando un nuevo registro
                if (oDetalle.Guardar())
                {
                    //Se guardo correctamente
                    MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //No se guardo correctamente
                    MessageBox.Show("El registro no fue agregado. El autor ya estaba agregado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CargarAutoresAgregados();
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
                    CLS.LibrosAutores oLibro_autor = new CLS.LibrosAutores();
                    oLibro_autor.IdLibro_Autor = dtgAutoresAgregados.CurrentRow.Cells["idLibro_autor"].Value.ToString();
                    if (oLibro_autor.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAutoresAgregados();
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
