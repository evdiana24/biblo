using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class VisorLibros : Form
    {
        private void cargar()
        {
            try
            {
                //CREACION DE OBJETO REPORTE VACIO
                REP.LibrosReportes oLibros = new REP.LibrosReportes();
                //LLENAMOS EL OBJETO DEL REPORTE CON LA C ONSULTA
                oLibros.SetDataSource(DataSource.Consultas.REPORTE_LIBROS());
                //INDICAMOS EL REPORTE A VISUALIZAR EN EL VISOR
                crvVisor.ReportSource = oLibros;
            }
            catch (Exception)
            {


            }
        }
        public VisorLibros()
        {
            InitializeComponent();
            cargar();
        }
    }
}
