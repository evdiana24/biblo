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
    public partial class EditorialEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Editoriales oEditorial = new CLS.Editoriales();

                    //Sincronizar el objeto con la interfaz
                    oEditorial.IDEditorial = txbIdEditorial.Text;
                    oEditorial.Editorial = txbEditorial.Text;

                    //Operamos segun sea el caso
                    if (txbIdEditorial.TextLength > 0)
                    {
                        //Estoy editando
                        if (oEditorial.Actualizar())
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
                        if (oEditorial.Guardar())
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
                if (txbEditorial.TextLength == 0)
                {
                    Notificador.SetError(txbEditorial, "Escriba una editorial");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public EditorialEdicion()
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
