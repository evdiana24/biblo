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
    public partial class UsuarioLectorEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.UsuariosLectores oUsuarioLector = new CLS.UsuariosLectores();

                    //Sincronizar el objeto con la interfaz
                    oUsuarioLector.IDUsuario = txbIdUsuario.Text;
                    oUsuarioLector.Usuario = txbUsuario.Text;
                    oUsuarioLector.Clave = txbClave.Text;
                    oUsuarioLector.Estado = cmbEstado.Text;
                    oUsuarioLector.Carnet = cmbCarnet.Text;
                    oUsuarioLector.Fecha_Creacion = dtFechaCreacion.Value.ToString("yyyy/MM/dd hh:mm:ss");
                    oUsuarioLector.IDLector = txbIdLector.Text;
                    //oUsuarioLector.IDRol = txbIdRol.Text;
                    oUsuarioLector.IDRol = "2";

                    //Operamos segun sea el caso
                    if (txbIdUsuario.TextLength > 0)
                    {
                        //Estoy editando
                        if (oUsuarioLector.Actualizar())
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
                        if (oUsuarioLector.Guardar())
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
                if (cmbCarnet.Text.Length == 0)
                {
                    Notificador.SetError(cmbCarnet, "Seleccione si cuenta con un carnet");
                    Validado = false;
                }
                if (dtFechaCreacion.Text.Length == 0)
                {
                    Notificador.SetError(dtFechaCreacion, "Seleccione la fecha de creación del usuario");
                    Validado = false;
                }
                if (txbIdLector.Text.Length == 0)
                {
                    Notificador.SetError(txbIdLector, "Seleccione el ID del lector");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public UsuarioLectorEdicion()
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
                General.GUI.LectoresGestion f = new General.GUI.LectoresGestion();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdLector.Text = f.IDLectorSeleccionado;
                    txbLector.Text = f.LectorSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
