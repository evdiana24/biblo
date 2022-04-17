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
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign() {
            panelCuentas.Visible = false;
            panelLibros.Visible = false;
            panelPrestamos.Visible = false;
            panelPagos.Visible = false;
            panelAutores.Visible = false;
            panelEditoriales.Visible = false;
            panelCategorias.Visible = false;
            
        }
        //Ocultar submenu
        private void hideSubMenu() {
            if (panelCuentas.Visible == true)
            {
                panelCuentas.Visible = false;
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
            if (panelAutores.Visible == true)
            {
                panelAutores.Visible = false;
            }
            if (panelEditoriales.Visible == true)
            {
                panelEditoriales.Visible = false;
            }
            if (panelCategorias.Visible == true)
            {
                panelCategorias.Visible = false;
            }
        }
        private void showSubMenu(Panel Submenu) {
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
        private void btnSlider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 167)
            {
                MenuVertical.Width = 60;
            }
            
            /*if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
                
            }*/
            else
            {
                MenuVertical.Width = 167;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        

        

        private void btnGestionCuentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCuentas);
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGestionLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibros);
        }

        private void btnAgregarlibros_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVerLibros_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamos);
        }

        private void btnVerprestamos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPagos);
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVerMoras_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGestionAutores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAutores);
        }

        private void btnAgregarAutores_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnListaAutores_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGestionEditoriales_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEditoriales);
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCategorias);
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVerCategoria_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
