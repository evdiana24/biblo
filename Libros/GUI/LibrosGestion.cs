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
    public partial class LibrosGestion : Form
    {
        String _IDLibroSeleccionado;
        String _LibroSeleccionado;
        bool _Seleccionado = false;
        
        public string IDLibroSeleccionado
        {
            get
            {
                return _IDLibroSeleccionado;
            }
        }

        public string LibroSeleccionado
        {
            get
            {
                return _LibroSeleccionado;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
            }
        }

        public LibrosGestion()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDLibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["tID"].Value.ToString();
                _LibroSeleccionado = dtgLibrosGestion.CurrentRow.Cells["tTitulo"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }
    }
}
