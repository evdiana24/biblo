using DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfiles.CLS
{
    class CambiarClave
    {
        String _nuevaClave;
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        public string NuevaClave
        {
            get
            {
                return _nuevaClave;
            }

            set
            {
                _nuevaClave = value;
            }
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                if(oSesion.IDRol == "2")
                {
                    Sentencia.Append("UPDATE usuarios_lectores SET ");
                    Sentencia.Append("clave='" + Encriptacion.Encrypt(this.NuevaClave) + "' ");
                    Sentencia.Append("WHERE idUsuario=" + this.oSesion.IDUsuario + ";");

                    if (operacion.Actualizar(Sentencia.ToString()) > 0)
                    {
                        Resultado = true;
                    }
                }
                else
                {
                    Sentencia.Append("UPDATE usuarios_empleados SET ");
                    Sentencia.Append("clave='" + Encriptacion.Encrypt(this.NuevaClave) + "' ");
                    Sentencia.Append("WHERE idUsuario=" + this.oSesion.IDUsuario + ";");

                    if (operacion.Actualizar(Sentencia.ToString()) > 0)
                    {
                        Resultado = true;
                    }
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
