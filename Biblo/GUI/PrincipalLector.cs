using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Biblo.GUI
{
    public partial class PrincipalLector : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;
        public PrincipalLector()
        {
            InitializeComponent();
            CustomizeDesign();
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
        }
        private void CustomizeDesign()
        {
            panelBuscarLibro.Visible = false;
            panelPagos.Visible = false;

            if(oSesion.IDRol == "2")
            {
                btnPagos.Visible = false;
            }

        }
        private void hideSubMenu() {
            if (panelBuscarLibro.Visible == true)
            {
                panelBuscarLibro.Visible = false;
            }
            if (panelPagos.Visible == true)
            {
                panelPagos.Visible = false;
            }
        }

        private void showSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<agregarAutor>();
        }

        private void btnBuscarlibro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBuscarLibro);
        }

        private void btnPortitulo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPorCategoria_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPorAutor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPorEditorial_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMisPrestamos_Click(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPagos);
        }

        private void btnMoras_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        private void btnBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
            }

            else
            {
                formulario.BringToFront();
            }

        }
    }
}
