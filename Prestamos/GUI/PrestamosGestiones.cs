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
    public partial class PrestamosGestiones : Form
    {
        BindingSource _DATOS = new BindingSource();
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

        private void CargarDatos()
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
                dtgEjemplares.Text = dtgEjemplares.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public PrestamosGestiones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrestamosGestiones_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
                    Close();
                }
                else
                {
                    //No se guardo correctamente
                    MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procesar();

            //txbIdPrestamo.Text = dtgDetallesPrestamos
        }
    }
}
