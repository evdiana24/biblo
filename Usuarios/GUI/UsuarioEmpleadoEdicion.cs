using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.GUI
{
    public partial class UsuarioEmpleadoEdicion : Form
    {
        private void LlenarRoles()
        {
            try
            {
                cmbRol.DataSource = DataSource.Consultas.TODOS_LOS_ROLES();
                cmbRol.DisplayMember = "Rol";
                cmbRol.ValueMember = "IDRol";
            }
            catch (Exception)
            {

            }
        }

        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.UsuariosEmpleados oUsuarioEmpleado = new CLS.UsuariosEmpleados();

                    //Sincronizar el objeto con la interfaz
                    oUsuarioEmpleado.IDUsuario = txbIdUsuario.Text;
                    oUsuarioEmpleado.Usuario = txbUsuario.Text;
                    oUsuarioEmpleado.Clave = txbClave.Text;
                    oUsuarioEmpleado.Estado = cmbEstado.Text;
                    oUsuarioEmpleado.Fecha_Creacion = dtFechaCreacion.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    oUsuarioEmpleado.IDEmpleado = txbIdEmpleado.Text;
                    oUsuarioEmpleado.IdRol = cmbRol.SelectedValue.ToString();

                    //Operamos segun sea el caso
                    if (txbIdUsuario.TextLength > 0)
                    {
                        //Estoy editando
                        if (oUsuarioEmpleado.Actualizar())
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
                        if (oUsuarioEmpleado.Guardar())
                        {
                            //Se guardo correctamente
                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            //No se guardo correctamente
                            MessageBox.Show("El registro no fue agregado. El nombre de usuario ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txbUsuario.TextLength == 0)
                {
                    Notificador.SetError(txbUsuario, "Escriba el nombre de usuario");
                    Validado = false;
                }
                if (String.IsNullOrEmpty(txbIdUsuario.Text))
                {
                    if (txbClave.TextLength == 0)
                    {
                        Notificador.SetError(txbClave, "Escriba la contraseña");
                        Validado = false;
                    }
                    if (!txbClave.Text.Equals(txbRepiteClave.Text))
                    {
                        Notificador.SetError(txbRepiteClave, "Las claves no concuerdan");
                        Validado = false;
                    }
                }
                if (cmbEstado.Text.Length == 0)
                {
                    Notificador.SetError(cmbEstado, "Seleccione el estado del usuario");
                    Validado = false;
                }
                if (dtFechaCreacion.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaCreacion, "Seleccione la fecha de creación del usuario");
                    Validado = false;
                }
                if (txbIdEmpleado.Text.Length == 0)
                {
                    Notificador.SetError(txbIdEmpleado, "Seleccione el ID del empleado");
                    Validado = false;
                }
                if (cmbRol.Text.Length == 0)
                {
                    Notificador.SetError(cmbRol, "Seleccione un rol");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public UsuarioEmpleadoEdicion()
        {
            InitializeComponent();
            LlenarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdEmpleado.Text = f.IDEmpleadoSeleccionado;
                    txbEmpleado.Text = f.EmpleadoSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
