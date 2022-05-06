using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuraciones.GUI
{
    public partial class RolesEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Roles oRol = new CLS.Roles();

                    //Sincronizar el objeto con la interfaz
                    oRol.IdRol = txbIdRol.Text;
                    oRol.Rol = txbRol.Text;

                    //Estoy insertando un nuevo registro
                    if (oRol.Guardar())
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
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validar()
        {
            Boolean Validado = true;
            try
            {
                Notificador.Clear();
                if (txbRol.TextLength == 0)
                {
                    Notificador.SetError(txbRol, "Escriba un rol");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
