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
    public partial class EmpleadoEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Empleados oEmpleado = new CLS.Empleados();

                    //Sincronizar el objeto con la interfaz
                    oEmpleado.IdEmpleado = txbIdEmpleado.Text;
                    oEmpleado.Nombre = txbNombre.Text;
                    oEmpleado.Fecha_nacimiento = dtFechaNacimiento.Value.Date.ToString("yyyy/MM/dd");
                    oEmpleado.Dui = txbDUI.Text;
                    oEmpleado.Nit = txbNIT.Text;
                    oEmpleado.Genero = cmbGenero.Text;
                    oEmpleado.Telefono = txbTelefono.Text;
                    oEmpleado.Correo = txbCorreo.Text;
                    oEmpleado.Direccion = txbDireccion.Text;
                    oEmpleado.Fecha_contratacion = dtFechaContratacion.Value.Date.ToString("yyyy/MM/dd");

                    //Operamos segun sea el caso
                    if (txbIdEmpleado.TextLength > 0)
                    {
                        //Estoy editando
                        if (oEmpleado.Actualizar())
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
                        if (oEmpleado.Guardar())
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
                if (txbDUI.TextLength == 0)
                {
                    Notificador.SetError(txbDUI, "Escriba el número de DUI");
                    Validado = false;
                }
                if (txbNIT.TextLength == 0)
                {
                    Notificador.SetError(txbNIT, "Escriba el número de NIT");
                    Validado = false;
                }
                if (cmbGenero.Text.Length == 0)
                {
                    Notificador.SetError(cmbGenero, "Seleccione su género");
                    Validado = false;
                }
                if (txbTelefono.TextLength == 0)
                {
                    Notificador.SetError(txbTelefono, "Escriba el número de teléfono");
                    Validado = false;
                }
                if (txbCorreo.TextLength == 0)
                {
                    Notificador.SetError(txbCorreo, "Escriba el correo electrónico");
                    Validado = false;
                }
                if (txbDireccion.TextLength == 0)
                {
                    Notificador.SetError(txbDireccion, "Escriaba la dirección");
                    Validado = false;
                }
                if (dtFechaContratacion.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaNacimiento, "Seleccione la fecha de contratación");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }


            return Validado;
        }

        public EmpleadoEdicion()
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
