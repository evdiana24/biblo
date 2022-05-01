using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class LectorEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Lectores oLector = new CLS.Lectores();

                    //Sincronizar el objeto con la interfaz
                    oLector.IdLector = txbIdLector.Text;
                    oLector.Nombre = txbNombre.Text;
                    oLector.Fecha_nacimiento = dtFechaNacimiento.Value.Date.ToString("yyyy/MM/dd");
                    oLector.Correo = txbCorreo.Text;
                    oLector.Telefono = txbTelefono.Text;
                    oLector.Genero = cmbGenero.Text;
                    oLector.Direccion = txbDireccion.Text;

                    //Operamos segun sea el caso
                    if (txbIdLector.TextLength > 0)
                    {
                        //Estoy editando
                        if (oLector.Actualizar())
                        {
                            //Se actualizo correctamente
                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            //No se actualizo correctamente
                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Estoy insertando un nuevo registro
                        if (oLector.Guardar())
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
                if (txbNombre.TextLength == 0)
                {
                    Notificador.SetError(txbNombre, "Escriba al menos un nombre");
                    Validado = false;
                }
                if (dtFechaNacimiento.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaNacimiento, "Escriba la fecha de nacimiento");
                    Validado = false;
                }
                if (txbCorreo.TextLength == 0)
                {
                    Notificador.SetError(txbCorreo, "Escriba el correo electrónico");
                    Validado = false;
                }
                if (txbTelefono.TextLength == 0)
                {
                    Notificador.SetError(txbTelefono, "Escriba el número de teléfono");
                    Validado = false;
                }
                if (cmbGenero.Text.Length == 0)
                {
                    Notificador.SetError(cmbGenero, "Seleccione su género");
                    Validado = false;
                }
                if (txbDireccion.TextLength == 0)
                {
                    Notificador.SetError(txbDireccion, "Escriaba la dirección");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public LectorEdicion()
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
