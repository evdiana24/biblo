using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros.GUI
{
    public partial class LibroEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Libros oLibro = new CLS.Libros();

                    //Sincronizar el objeto con la interfaz
                    oLibro.Titulo = txbTitulo.Text;
                    oLibro.Anio_publicacion = txbAnio.Text;
                    oLibro.Edicion = txbEdicion.Text;
                    oLibro.IdEditorial = txbEditorial.Text;

                    //Operamos segun sea el caso
                    if (txbIdLibro.TextLength > 0)
                    {
                        //Estoy editando
                        if (oLibro.Actualizar())
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
                        if (oLibro.Guardar())
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
                if (txbTitulo.TextLength == 0)
                {
                    Notificador.SetError(txbTitulo, "Escriba el título del libro");
                    Validado = false;
                }
                if (txbAnio.Text.Length == 0)
                {
                    Notificador.SetError(txbAnio, "Escriba el año de publicación");
                    Validado = false;
                }
                if (txbEdicion.TextLength == 0)
                {
                    Notificador.SetError(txbEdicion, "Escriba la edición");
                    Validado = false;
                }
                if (txbEditorial.TextLength == 0)
                {
                    Notificador.SetError(txbEditorial, "Escriba el ID de la editorial");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public LibroEdicion()
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
