
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class VisorPrestamos : Form
    {
        private void cargar()
        {
            try
            {
                //CREACION DE OBJETO REPORTE VACIO
                REP.PrestamosReporte oPrestamos = new REP.PrestamosReporte();
                //LLENAMOS EL OBJETO DEL REPORTE CON LA C ONSULTA
                oPrestamos.SetDataSource(DataSource.Consultas.REPORTE_PRESTAMOS());
                //INDICAMOS EL REPORTE A VISUALIZAR EN EL VISOR
                crvVisor.ReportSource = oPrestamos;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        public VisorPrestamos()
        {
            InitializeComponent();
            cargar();
        }
    }
}
