using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Editoriales
    {
        String _IDEditorial;
        String _Editorial;

        public string IDEditorial
        {
            get
            {
                return _IDEditorial;
            }

            set
            {
                _IDEditorial = value;
            }
        }

        public string Editorial
        {
            get
            {
                return _Editorial;
            }

            set
            {
                _Editorial = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO editoriales(editorial) values(");
                Sentencia.Append("'" + this._Editorial + "');");

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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE editoriales SET ");
                Sentencia.Append("editorial='" + this._Editorial + "' ");
                Sentencia.Append("WHERE idEditorial=" + this._IDEditorial + ";");
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
                Sentencia.Append("DELETE FROM editoriales ");
                Sentencia.Append("WHERE idEditorial=" + this._IDEditorial + ";");
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
