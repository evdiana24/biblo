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
using Biblo.CLS;

namespace Biblo.GUI
{
    public partial class Principal : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public Principal()
        {
            InitializeComponent();
            RestringirOpciones();
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
            panelConfiguraciones.Visible = false;
        }

        private void RestringirOpciones()
        {
            if (oSesion.IDRol == "1")
            {
                btnConfiguraciones.Visible = false;
            }

            if (oSesion.IDRol == "2")
            {
                btnConfiguraciones.Visible = false;
                btnInformes.Visible = false;
                btnUsuarios.Visible = false;
                btnGeneral.Visible = false;
            }

            if (oSesion.IDRol == "4")
            {
                btnConfiguraciones.Visible = false;
                btnInformes.Visible = false;
                btnUsuarios.Visible = false;
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
            if (panelConfiguraciones.Visible == true)
            {
                panelConfiguraciones.Visible = false;
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
                formulario.Dock = DockStyle.Fill;
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
            if (oSesion.IDRol == "2")
            {
                AbrirFormulario<Perfiles.GUI.PerfilLector>();
            }
            else
            {
                AbrirFormulario<Perfiles.GUI.PerfilEmpleado>();
            }
        }

        //GENERAL
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGeneral);
            if (!oSesion.VerificarPermiso(2))
            {
                btnGAutores.Visible = false;
            }

            if (!oSesion.VerificarPermiso(3))
            {
                btnGCategorias.Visible = false;
            }

            if (!oSesion.VerificarPermiso(4))
            {
                btnGEditoriales.Visible = false;
            }

            if (!oSesion.VerificarPermiso(5))
            {
                btnGEmpleados.Visible = false;
            }

            if (!oSesion.VerificarPermiso(6))
            {
                btnGLectores.Visible = false;
            }
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

            if (!oSesion.VerificarPermiso(7))
            {
                btnGUsuariosEmpleados.Visible = false;
            }

            if (!oSesion.VerificarPermiso(8))
            {
                btnGUsuariosLectores.Visible = false;
            }
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

            if (!oSesion.VerificarPermiso(9))
            {
                btnGLibros.Visible = false;
            }

            if (!oSesion.VerificarPermiso(10))
            {
                btnGEjemplares.Visible = false;
            }

            if (!oSesion.VerificarPermiso(11))
            {
                btnBuscarLibros.Visible = false;
            }
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
            AbrirFormulario<Libros.GUI.BuscarLibro>();
            hideSubMenu();
        }

        //PRÉSTAMOS
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamos);

            if (!oSesion.VerificarPermiso(12))
            {
                btnGPrestamos.Visible = false;
            }

            if (!oSesion.VerificarPermiso(13))
            {
                btnDetallesPrestamos.Visible = false;
            }

            if (!oSesion.VerificarPermiso(14))
            {
                btnMisPrestamos.Visible = false;
            }

            if (!oSesion.VerificarPermiso(15))
            {
                btnGestionarDevoluciones.Visible = false;
            }
        }

        private void btnGPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos.GUI.PrestamosGestion>();
            hideSubMenu();
        }

        private void btnDetallesPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos.GUI.DetallesPrestamosVista>();
            hideSubMenu();
        }

        private void btnMisPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos.GUI.misPrestamos>();
            hideSubMenu();
        }

        private void btnRegistrarDev_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Prestamos.GUI.DevolucionesGestion>();
            hideSubMenu();
        }
        
        //PAGOS
        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPagos);

            if (!oSesion.VerificarPermiso(16))
            {
                btnGMoras.Visible = false;
            }

            if (!oSesion.VerificarPermiso(17))
            {
                btnMisMoras.Visible = false;
            }

            if (!oSesion.VerificarPermiso(18))
            {
                btnGPagos.Visible = false;
            }

            if (!oSesion.VerificarPermiso(19))
            {
                btnHistorialPagos.Visible = false;
            }
        }

        private void btnMisMoras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos.GUI.MisMoras>();
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
            AbrirFormulario<Pagos.GUI.HistorialPagos>();
            hideSubMenu();
        }

        //INFORMES
        private void btnInformes_Click(object sender, EventArgs e)
        {

        }

        //CONFIGURACIONES
        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConfiguraciones);

            if (!oSesion.VerificarPermiso(21))
            {
                btnGRoles.Visible = false;
            }

            if (!oSesion.VerificarPermiso(22))
            {
                btnGPermisos.Visible = false;
            }

            if (!oSesion.VerificarPermiso(23))
            {
                btnGOpciones.Visible = false;
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Configuraciones.GUI.RolesGestion>();
            hideSubMenu();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Configuraciones.GUI.Permisos>();
            hideSubMenu();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Configuraciones.GUI.OpcionesGestion>();
            hideSubMenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
                if (f.Autorizado == true)
                {
                    this.Close();
                    Principal p = new Principal();
                    p.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informes.GUI.VisorPagos>();
        }

        private void btnInPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informes.GUI.VisorPrestamos>();
        }

        private void btnInLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informes.GUI.VisorLibros>();
        }

        private void btnInMoras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Informes.GUI.VisorMoras>();
        }
    }
}
