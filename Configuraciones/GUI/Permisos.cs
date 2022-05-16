using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuraciones.GUI
{
    public partial class Permisos : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.PERMISOS_DE_UN_ROL(cmbRol.SelectedValue.ToString());
                dtgDatos.DataSource = _DATOS;
            }
            catch
            {

            }
        }

        private void LlenarRoles()
        {
            try
            {
                cmbRol.DataSource = DataSource.Consultas.TODOS_LOS_ROLES();
                cmbRol.DisplayMember = "rol";
                cmbRol.ValueMember = "idRol";
                Cargar();
            }
            catch (Exception)
            {

            }
        }

        public Permisos()
        {
            InitializeComponent();
            LlenarRoles();

        }

        private void cbbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    String Valor;
                    CLS.Permisos oPermiso = new CLS.Permisos();


                    Valor = dtgDatos.CurrentRow.Cells["Asignado"].Value.ToString();
                    if (Valor.Equals("1"))
                    {
                        oPermiso.IDPermiso = dtgDatos.CurrentRow.Cells["idPermiso"].Value.ToString();
                        oPermiso.Eliminar();
                    }
                    else
                    {
                        oPermiso.IDOpcion = dtgDatos.CurrentRow.Cells["idOpcion"].Value.ToString();
                        oPermiso.IDRol = cmbRol.SelectedValue.ToString();
                        oPermiso.Guardar();
                    }
                    Cargar();
                }
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
