using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuraciones.CLS
{
    class Opciones
    {
        String _idOpcion;
        String _opcion;

        public string IdOpcion
        {
            get
            {
                return _idOpcion;
            }

            set
            {
                _idOpcion = value;
            }
        }

        public string Opcion
        {
            get
            {
                return _opcion;
            }

            set
            {
                _opcion = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO opciones(opcion) values(");
                Sentencia.Append("'" + this._opcion + "');");

                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM opciones ");
                Sentencia.Append("WHERE idOpcion=" + this._idOpcion + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
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
