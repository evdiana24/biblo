using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblo.CLS
{
    class AppManager :ApplicationContext
    {
        public Boolean Splash()
        {
            Boolean _Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return _Resultado;
        }

        public Boolean Login()
        {
            Boolean _Resultado = true;
            GUI.Login f = new GUI.Login();
            f.ShowDialog();
            _Resultado = f.Autorizado;
            return _Resultado;
        }
       
        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
