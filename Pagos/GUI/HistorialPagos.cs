using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagos.GUI
{
    public partial class HistorialPagos : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.HISTORIAL_PAGOS(oSesion.IDUsuario);
                dtgPagosGestion.AutoGenerateColumns = false;
                dtgPagosGestion.DataSource = _DATOS;
                lblRegistros.Text = dtgPagosGestion.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        public HistorialPagos()
        {
            InitializeComponent();
        }

        private void PagosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
