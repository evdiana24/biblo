using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos.CLS
{
    class Pagos
    {
        String _IDpago;
        String _Descripcion;
        String _Fecha_Pago;
        String _Total;
        String _IDUsuario_Lector;
        String _IDUsuario_Empleado;

        public string IDpago
        {
            get
            {
                return _IDpago;
            }

            set
            {
                _IDpago = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string Fecha_Pago
        {
            get
            {
                return _Fecha_Pago;
            }

            set
            {
                _Fecha_Pago = value;
            }
        }

        public string Total
        {
            get
            {
                return _Total;
            }

            set
            {
                _Total = value;
            }
        }

        public string IDUsuario_Lector
        {
            get
            {
                return _IDUsuario_Lector;
            }

            set
            {
                _IDUsuario_Lector = value;
            }
        }

        public string IDUsuario_Empleado
        {
            get
            {
                return _IDUsuario_Empleado;
            }

            set
            {
                _IDUsuario_Empleado = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO pagos(descripcion, fecha_pago, total, idUsuario_lector, idUsuario_empleado) values(");
                Sentencia.Append("'" + this._Descripcion + "',");
                Sentencia.Append("'" + this._Fecha_Pago + "',");
                Sentencia.Append("'" + this._Total + "',");
                Sentencia.Append("'" + this._IDUsuario_Lector + "',");
                Sentencia.Append("'" + this._IDUsuario_Empleado + "');");

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
                Sentencia.Append("UPDATE pagos SET ");
                Sentencia.Append("descripcion='" + this._Descripcion + "',");
                Sentencia.Append("fecha_pago='" + this._Fecha_Pago + "',");
                Sentencia.Append("total='" + this._Total + "',");
                Sentencia.Append("idUsuario_lector='" + this._IDUsuario_Lector + "',");
                Sentencia.Append("idUsuario_empleado='" + this._IDUsuario_Empleado + "' ");
                Sentencia.Append("WHERE idPago=" + this._IDpago + ";");
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
                Sentencia.Append("DELETE FROM pagos ");
                Sentencia.Append("WHERE idPago=" + this._IDpago + ";");
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
