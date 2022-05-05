using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagos.GUI
{
    public partial class MoraEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Moras oMora = new CLS.Moras();

                    //Sincronizar el objeto con la interfaz
                    oMora.IdMora = txbIdMora.Text;
                    oMora.IdDetalle = txbIdDetalle.Text;
                    oMora.TotalMora = txbTotal.Text;
                    oMora.Estado = cmbEstadoMora.Text;

                    //Operamos segun sea el caso
                    if (txbIdMora.TextLength > 0)
                    {
                        //Estoy editando
                        if (oMora.Actualizar())
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
                        if (oMora.Guardar())
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
                if (txbIdDetalle.TextLength == 0)
                {
                    Notificador.SetError(txbIdDetalle, "Escriba el ID del detalle de mora");
                    Validado = false;
                }
                if (txbTotal.Text.Length == 0)
                {
                    Notificador.SetError(txbTotal, "Escriba el total");
                    Validado = false;
                }
                if (cmbEstadoMora.Text.Length == 0)
                {
                    Notificador.SetError(cmbEstadoMora, "Seleccione el estado de la mora");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public MoraEdicion()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    General.GUI.EditorialesGestion f = new General.GUI.EditorialesGestion();
            //    f.ShowDialog();
            //    if (f.Seleccionado)
            //    {
            //        txbIdEditorial.Text = f.IDEditorialSeleccionado;
            //        txbEditorial.Text = f.EditorialSeleccionado;
            //    }
            //}
            //catch (Exception)
            //{

            //}
        }
    }
}
