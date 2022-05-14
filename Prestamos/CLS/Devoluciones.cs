using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.CLS
{
    class Devoluciones
    {
        String _idDevolucion;
        String _idDetalle;
        String _condicionLibro;
        String _descripcion;
        String _fechaEntregado;

        public string IdDevolucion
        {
            get
            {
                return _idDevolucion;
            }

            set
            {
                _idDevolucion = value;
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

        public string CondicionLibro
        {
            get
            {
                return _condicionLibro;
            }

            set
            {
                _condicionLibro = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public string FechaEntregado
        {
            get
            {
                return _fechaEntregado;
            }

            set
            {
                _fechaEntregado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO devoluciones(idDetalle,condicion_libro,descripcion,fecha_entregado) values(");
                Sentencia.Append("'" + this._idDetalle + "',");
                Sentencia.Append("'" + this._condicionLibro + "',");
                Sentencia.Append("'" + this._descripcion + "',");
                Sentencia.Append("'" + this._fechaEntregado + "');");

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
                Sentencia.Append("UPDATE devoluciones SET ");
                Sentencia.Append("idDetalle='" + this._idDetalle + "',");
                Sentencia.Append("condicion_libro='" + this._condicionLibro + "',");
                Sentencia.Append("descripcion='" + this._descripcion + "',");
                Sentencia.Append("fecha_entregado" + this._fechaEntregado + "' WHERE idDevolucion=" + this._idDevolucion + ";");
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
                Sentencia.Append("DELETE FROM devoluciones ");
                Sentencia.Append("WHERE idDevolucion=" + this._idDevolucion + ";");
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
