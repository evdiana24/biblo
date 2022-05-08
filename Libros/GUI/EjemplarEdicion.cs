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
    public partial class EjemplarEdicion : Form
    {
        private void Procesar()
        {
            try
            {
                if (Validar())
                {
                    //Creamos el objeto entidad
                    CLS.Ejemplares oEjemplar = new CLS.Ejemplares();

                    //Sincronizar el objeto con la interfaz
                    oEjemplar.IDEjemplar = txbIdEjemplar.Text;
                    oEjemplar.IDLibro = txbLibro.Text;
                    oEjemplar.Estado = cmbEstado.Text;

                    //Operamos segun sea el caso
                    if (txbIdEjemplar.TextLength > 0)
                    {
                        //Estoy editando
                        if (oEjemplar.Actualizar())
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
                        if (oEjemplar.Guardar())
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
                if (txbLibro.TextLength == 0)
                {
                    Notificador.SetError(txbLibro, "Seleccione el Libro");
                    Validado = false;
                }
                if (cmbEstado.Text.Length == 0)
                {
                    Notificador.SetError(cmbEstado, "Seleccione el estado del ejemplar");
                    Validado = false;
                }
            }
            catch (Exception)
            {
                Validado = false;
            }
            return Validado;
        }

        public EjemplarEdicion()
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

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.LibrosGestion f = new GUI.LibrosGestion();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.ShowDialog();
                if (f.Seleccionado)
                {
                    txbIdLibro.Text = f.IDLibroSeleccionado;
                    txbLibro.Text = f.LibroSeleccionado;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
