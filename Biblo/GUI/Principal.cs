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
    public partial class Principal : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public Principal()
        {
            InitializeComponent();
            CustomizeDesign();
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
        }

        private void CustomizeDesign()
        {
            panelGeneral.Visible = false;
            panelUsuarios.Visible = false;
            panelLibros.Visible = false;
            panelPrestamos.Visible = false;
            panelPagos.Visible = false;

            if (oSesion.IDRol == "2")
            {
                btnMisPrestamos.Visible = false;
            }

        }

        private void hideSubMenu()
        {
            if (panelGeneral.Visible == true)
            {
                panelGeneral.Visible = false;
            }
            if (panelUsuarios.Visible == true)
            {
                panelUsuarios.Visible = false;
            }
            if (panelLibros.Visible == true)
            {
                panelLibros.Visible = false;
            }
            if (panelPrestamos.Visible == true)
            {
                panelPrestamos.Visible = false;
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

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                formulario.BringToFront();
            }

        }

        //MI PERFIL
        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<misDatos>();
        }

        //GENERAL
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGeneral);
        }

        private void btnGAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.GUI.AutoresGestion>();
            hideSubMenu();
        }

        private void btnGCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.GUI.CategoriasGestion>();
            hideSubMenu();
        }

        private void btnGEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.GUI.EditorialesGestion>();
            hideSubMenu();
        }

        private void btnGEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.GUI.EmpleadosGestion>();
            hideSubMenu();
        }

        private void btnGLectores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<General.GUI.LectoresGestion>();
            hideSubMenu();
        }

        //USUARIOS
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarios);
        }

        private void btnGUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Usuarios.GUI.UsuariosEmpleadosGestion>();
            hideSubMenu();
        }

        private void btnGUsuariosLectores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Usuarios.GUI.UsuariosLectoresGestion>();
            hideSubMenu();
        }

        //LIBROS
        private void btnLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibros);
        }

        private void btnGLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Libros.GUI.LibrosGestion>();
            hideSubMenu();
        }

        private void btnGEjemplares_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Libros.GUI.EjemplaresGestion>();
            hideSubMenu();
        }

        private void btnBuscarLibros_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Libros.GUI.LibrosGestion>();
            hideSubMenu();
        }

        //PRÉSTAMOS
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamos);
        }

        private void btnGPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        private void btnDetallesPrestamos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        private void btnMisPrestamos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        private void btnRegistrarDev_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }
        
        //PAGOS
        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPagos);
        }

        private void btnMisMoras_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        private void btnGMoras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos.GUI.MorasGestion>();
            hideSubMenu();
        }

        private void btnGPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos.GUI.PagosGestion>();
            hideSubMenu();
        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        //CERRAR SESION
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
