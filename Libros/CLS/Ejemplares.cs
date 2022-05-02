using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.CLS
{
    class Ejemplares
    {
        String _IDEjemplar;
        String _IDLibro;
        String _Estado;

        public string IDEjemplar
        {
            get
            {
                return _IDEjemplar;
            }

            set
            {
                _IDEjemplar = value;
            }
        }

        public string IDLibro
        {
            get
            {
                return _IDLibro;
            }

            set
            {
                _IDLibro = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO ejemplares(idLibro, estado) values(");
                Sentencia.Append("'" + this._IDLibro + "',");
                Sentencia.Append("'" + this._Estado + "');");

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
                Sentencia.Append("UPDATE ejemplares SET ");
                Sentencia.Append("idLibro='" + this._IDLibro + "',");
                Sentencia.Append("estado='" + this._Estado + "' ");
                Sentencia.Append("WHERE idEjemplar=" + this._IDEjemplar + ";");
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
                Sentencia.Append("DELETE FROM ejemplares ");
                Sentencia.Append("WHERE idEjemplar=" + this._IDEjemplar + ";");
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
