using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.GUI
{
    public partial class PrestamoEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Prestamos oPrestamo = new CLS.Prestamos();

                    //Sincronizar el objeto con la interfaz
                    oPrestamo.IdPrestamo = txbIdPrestamo.Text;
                    oPrestamo.IdUsuario_lector = txbIdLector.Text;
                    oPrestamo.IdUsuario_empleado = txbIdEmpleado.Text;
                    oPrestamo.Fecha_prestamo = dtFechaPrestamo.Value.Date.ToString("yyyy/MM/dd");

                    //Operamos segun sea el caso
                    if (txbIdPrestamo.TextLength > 0)
                    {
                        //Estoy editando
                        if (oPrestamo.Actualizar())
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
                        if (oPrestamo.Guardar())
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
                if (txbIdLector.TextLength == 0)
                {
                    Notificador.SetError(txbIdLector, "Escriba el ID del lector");
                    Validado = false;
                }
                if (txbIdEmpleado.Text.Length == 0)
                {
                    Notificador.SetError(txbIdEmpleado, "Escriba el ID del empleado");
                    Validado = false;
                }
                if (dtFechaPrestamo.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaPrestamo, "Seleccione la fecha del prestamo");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public PrestamoEdicion()
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
