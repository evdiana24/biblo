using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblo.GUI
{
    public partial class Login : Form
    {
        Boolean _Autorizado = false;
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }

            set
            {
                _Autorizado = value;
            }
        }

        private void Validar()
        {
            DataTable Datos = new DataTable();
            try
            {
                Datos = DataSource.Consultas.INICIO_SESION(txbUsuario.Text, txbClave.Text);
                if(Datos.Rows.Count == 1)
                {
                    oSesion.IDUsuario = Datos.Rows[0]["IDUsuario"].ToString();
                    oSesion.Usuario = Datos.Rows[0]["Usuario"].ToString();
                    oSesion.IDRol = Datos.Rows[0]["IDRol"].ToString();
                    oSesion.Rol = Datos.Rows[0]["Rol"].ToString();
                    oSesion.ObtenerPermisos();
                    _Autorizado = true;
                    Close();
                }

                else
                {
                    lblMensaje.Text = "Usuario o clave incorrectos";
                }
            }
            catch(Exception)
            {
                
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
