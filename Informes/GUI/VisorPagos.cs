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
    public partial class VisorPagos : Form
    {
        private void cargar()
        {
            try
            {
                //CREACION DE OBJETO REPORTE VACIO
                REP.PagosReporte oPagos = new REP.PagosReporte();
                //LLENAMOS EL OBJETO DEL REPORTE CON LA C ONSULTA
                oPagos.SetDataSource(DataSource.Consultas.REPORTE_PAGOS());
                //INDICAMOS EL REPORTE A VISUALIZAR EN EL VISOR
                crvVisor.ReportSource = oPagos;
            }
            catch (Exception)
            {


            }
        }
        public VisorPagos()
        {
            InitializeComponent();
            cargar();
        }
    }
}
