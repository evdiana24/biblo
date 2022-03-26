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
    public partial class Principal : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public Principal()
        {
            InitializeComponent();
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermiso(2))
            {
                Principal f = new Principal();
                f.Show();
            }
        }
    }
}
