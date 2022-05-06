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
    public partial class PagoEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Pagos oPago = new CLS.Pagos();

                    //Sincronizar el objeto con la interfaz
                    oPago.IDpago = txbIdPago.Text;
                    oPago.Descripcion = cmbDescripcion.Text;
                    oPago.Fecha_Pago = dtFechaPago.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    oPago.Total = txbTotal.Text;
                    oPago.IDUsuario_Lector = txbIdUsuarioLector.Text;
                    oPago.IDUsuario_Empleado = txbIdUsuarioEmpleado.Text;

                    //Estoy insertando un nuevo registro
                    if (oPago.Guardar())
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
                if (cmbDescripcion.Text.Length == 0)
                {
                    Notificador.SetError(cmbDescripcion, "Seleccione la descripcion del pago");
                    Validado = false;
                }
                if (dtFechaPago.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaPago, "Seleccione la fecha del pago");
                    Validado = false;
                }
                if (txbTotal.Text.Length == 0)
                {
                    Notificador.SetError(txbTotal, "Escriba el total a pagar");
                    Validado = false;
                }
                if (txbIdUsuarioLector.Text.Length == 0)
                {
                    Notificador.SetError(txbIdUsuarioLector, "Seleccione el ID del usuario lector");
                    Validado = false;
                }
                if (txbIdUsuarioEmpleado.Text.Length == 0)
                {
                    Notificador.SetError(txbIdUsuarioEmpleado, "Seleccione el ID del usuario empleado");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public PagoEdicion()
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

        private void btnBuscarLector_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios.GUI.UsuariosLectoresGestion f = new Usuarios.GUI.UsuariosLectoresGestion();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdUsuarioLector.Text = f.IDUsuarioSeleccionado;
                    txbUsuarioLector.Text = f.UsuarioSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios.GUI.UsuariosEmpleadosGestion f = new Usuarios.GUI.UsuariosEmpleadosGestion();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdUsuarioEmpleado.Text = f.IDUsuarioSeleccionado;
                    txbUsuarioEmpleado.Text = f.UsuarioSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txbTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
