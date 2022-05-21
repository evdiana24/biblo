using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.GUI
{
    public partial class DetallesPrestamos : Form
    {
        BindingSource _DATOS = new BindingSource();
        BindingSource _DETALLES = new BindingSource();
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

        private void CargarEjemplares()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_EJEMPLARES_DISPONIBLES();
                Filtrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void CargarDetallesPrestamos()
        {
            try
            {
                _DETALLES.DataSource = DataSource.Consultas.DETALLES_POR_ID_PRESTAMO(txbIdPrestamo.Text);
                dtgDetallesPrestamos.AutoGenerateColumns = false;
                dtgDetallesPrestamos.DataSource = _DETALLES;
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
                    _DATOS.Filter = "titulo LIKE '%" + txbFiltro.Text + "%' OR categoria LIKE '%" + txbFiltro.Text + "%' OR autor LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgEjemplares.AutoGenerateColumns = false;
                dtgEjemplares.DataSource = _DATOS;
                lblEstado.Text = dtgEjemplares.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public DetallesPrestamos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrestamosGestiones_Load(object sender, EventArgs e)
        {
            CargarEjemplares();
            CargarDetallesPrestamos();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDEjemplarSeleccionado = dtgEjemplares.CurrentRow.Cells["idEjemplar"].Value.ToString();
                _EjemplarSeleccionado = dtgEjemplares.CurrentRow.Cells["titulo"].Value.ToString();
                _Seleccionado = true;

                txbIdEjemplar.Text = IDEjemplarSeleccionado;
                txbEjemplar.Text = EjemplarSeleccionado;
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
                CLS.DetallesPrestamos oDetalle = new CLS.DetallesPrestamos();

                //Sincronizar el objeto con la interfaz
                oDetalle.IdPrestamo = txbIdPrestamo.Text;
                oDetalle.IdEjemplar = txbIdEjemplar.Text;
                oDetalle.Fecha_devolucion = dtFechaDevolucion.Value.ToString("yyyy/MM/dd");

                //Estoy insertando un nuevo registro
                if (oDetalle.Guardar())
                {
                    //Se guardo correctamente
                    MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEjemplares();
                }
                else
                {
                    //No se guardo correctamente
                    MessageBox.Show("Sólo se permite un máximo de 5 ejemplares", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CargarDetallesPrestamos();
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
                    CLS.DetallesPrestamos oDetalle = new CLS.DetallesPrestamos();
                    oDetalle.IdDetalle = dtgDetallesPrestamos.CurrentRow.Cells["idDetalle"].Value.ToString();
                    if (oDetalle.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDetallesPrestamos();
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
