using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos.CLS
{
    class Moras
    {
        String _idMora;
        String _idDetalle;
        String _totalMora;
        String _estado;

        public string IdMora
        {
            get
            {
                return _idMora;
            }

            set
            {
                _idMora = value;
            }
        }

        public string IdDetalle
        {
            get
            {
                return _idDetalle;
            }

            set
            {
                _idDetalle = value;
            }
        }

        public string TotalMora
        {
            get
            {
                return _totalMora;
            }

            set
            {
                _totalMora = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO moras(idDetalle,totalMora,estado) values(");
                Sentencia.Append("'" + this._idDetalle + "',");
                Sentencia.Append("'" + this._totalMora + "',");
                Sentencia.Append("'" + this._estado + "');");

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
                Sentencia.Append("UPDATE moras SET ");
                Sentencia.Append("nombre='" + this._idDetalle + "',");
                Sentencia.Append("fecha_nacimiento='" + this._totalMora + "',");
                Sentencia.Append("fecha_contratacion" + this._estado + "' WHERE idMora=" + this._idMora + ";");
                if (operacion.Actualizar(Sentencia.ToString()) > 0)
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
                Sentencia.Append("DELETE FROM moras ");
                Sentencia.Append("WHERE idMora=" + this._idMora + ";");
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
