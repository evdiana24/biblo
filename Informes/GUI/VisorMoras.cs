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
    public partial class VisorMoras : Form
    {
        private void cargar()
        {
            try
            {
                //CREACION DE OBJETO REPORTE VACIO
                REP.MorasReportes oMoras = new REP.MorasReportes();
                //LLENAMOS EL OBJETO DEL REPORTE CON LA C ONSULTA
                oMoras.SetDataSource(DataSource.Consultas.REPORTE_MORAS());
                //INDICAMOS EL REPORTE A VISUALIZAR EN EL VISOR
                crvVisor.ReportSource = oMoras;
            }
            catch (Exception)
            {


            }
        }
        public VisorMoras()
        {
            InitializeComponent();
            cargar();
        }
    }
}
