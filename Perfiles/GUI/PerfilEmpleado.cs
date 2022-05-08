using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfiles.GUI
{
    public partial class PerfilEmpleado : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public PerfilEmpleado()
        {
            InitializeComponent();
            popularCampos();
        }

        private void popularCampos()
        {
            DataTable Datos = new DataTable();
            try
            {
                Datos = DataSource.Consultas.DATOS_EMPLEADO(oSesion.IDUsuario);

                txbNombre.Text = Datos.Rows[0]["nombre"].ToString();
                txbDui.Text = Datos.Rows[0]["dui"].ToString();
                txbNit.Text = Datos.Rows[0]["nit"].ToString();
                txbTelefono.Text = Datos.Rows[0]["telefono"].ToString();
                txbCorreo.Text = Datos.Rows[0]["correo"].ToString();
                txbFechaNacimiento.Text = Datos.Rows[0]["fecha_nacimiento"].ToString();
                txbGenero.Text = Datos.Rows[0]["genero"].ToString();
                txbDireccion.Text = Datos.Rows[0]["direccion"].ToString();
                txbUsuario.Text = Datos.Rows[0]["usuario"].ToString();
                txbFechaCreacion.Text = Datos.Rows[0]["fecha_creacion"].ToString();
                txbRol.Text = Datos.Rows[0]["rol"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            GUI.CambiarClave f = new GUI.CambiarClave();
            f.ShowDialog();
        }
    }
}
