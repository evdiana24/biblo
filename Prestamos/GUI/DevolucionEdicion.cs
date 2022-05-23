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
    public partial class DevolucionEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Devoluciones oDevolucion = new CLS.Devoluciones();

                    //Sincronizar el objeto con la interfaz
                    oDevolucion.IdDevolucion = txbIdDevolucion.Text;
                    oDevolucion.IdDetalle = txbIdDetalle.Text;
                    oDevolucion.CondicionLibro = cmbCondicion.Text;
                    oDevolucion.Descripcion = txbDescripcion.Text;
                    oDevolucion.FechaEntregado = dtFechaEntregado.Value.ToString("yyyy/MM/dd HH:mm:ss");

                    //Operamos segun sea el caso
                    if (txbIdDevolucion.TextLength > 0)
                    {
                        //Estoy editando
                        if (oDevolucion.Actualizar())
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
                        if (oDevolucion.Guardar())
                        {
                            //Se guardo correctamente
                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            //No se guardo correctamente
                            MessageBox.Show("El registro no fue agregado. La devolción fue previamente agregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txbIdDetalle.TextLength == 0)
                {
                    Notificador.SetError(txbIdDetalle, "Seleccione el ID del detalle de préstamo");
                    Validado = false;
                }
                if (cmbCondicion.Text.Length == 0)
                {
                    Notificador.SetError(cmbCondicion, "Seleccione la condición del libro");
                    Validado = false;
                }
                //if (txbDescripcion.TextLength == 0)
                //{
                //    Notificador.SetError(txbDescripcion, "Seleccione la fecha del prestamo");
                //    Validado = false;
                //}
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public DevolucionEdicion()
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

        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamos.GUI.DetallesPrestamosVista f = new Prestamos.GUI.DetallesPrestamosVista();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdDetalle.Text = f.IDDetalleSeleccionado;
                    txbTitulo.Text = f.TituloSeleccionado;
                    txbLector.Text = f.LectorSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
