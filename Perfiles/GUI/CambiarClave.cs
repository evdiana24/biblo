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
    public partial class CambiarClave : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.CambiarClave oClave = new CLS.CambiarClave();

                    //Sincronizar el objeto con la interfaz
                    oClave.NuevaClave = txbNuevaClave.Text;

                    //Estoy editando
                    if (oClave.Actualizar())
                    {
                        //Se actualizo correctamente
                        MessageBox.Show("La contraseña fue actualizada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                         //No se actualizo correctamente
                         MessageBox.Show("La contraseña no fue actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CambiarClave()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            Boolean Validado = true;
            try
            {
                Notificador.Clear();
                if (txbNuevaClave.TextLength == 0)
                {
                    Notificador.SetError(txbNuevaClave, "Escriba la nueva clave");
                    Validado = false;
                }
                if (!txbNuevaClave.Text.Equals(txbRepitaClave.Text))
                {
                    Notificador.SetError(txbRepitaClave, "Las claves no concuerdan");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        private void CambioDeClave()
        {
            
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
