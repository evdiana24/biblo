using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.CLS
{
    class Prestamos
    {
        String _idPrestamo;
        String _idUsuario_lector;
        String _idUsuario_empleado;
        String _fecha_prestamo;

        public string IdPrestamo
        {
            get
            {
                return _idPrestamo;
            }

            set
            {
                _idPrestamo = value;
            }
        }

        public string IdUsuario_lector
        {
            get
            {
                return _idUsuario_lector;
            }

            set
            {
                _idUsuario_lector = value;
            }
        }

        public string IdUsuario_empleado
        {
            get
            {
                return _idUsuario_empleado;
            }

            set
            {
                _idUsuario_empleado = value;
            }
        }

        public string Fecha_prestamo
        {
            get
            {
                return _fecha_prestamo;
            }

            set
            {
                _fecha_prestamo = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO prestamos(idUsuario_lector,idUsuario_empleado,fecha_prestamo) values(");
                Sentencia.Append("'" + this._idUsuario_lector + "',");
                Sentencia.Append("'" + this._idUsuario_empleado + "',");
                Sentencia.Append("'" + this._fecha_prestamo + "');");

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
                Sentencia.Append("UPDATE prestamos SET ");
                Sentencia.Append("nombre='" + this._idUsuario_lector + "',");
                Sentencia.Append("fecha_nacimiento='" + this._idUsuario_empleado + "',");
                Sentencia.Append("fecha_contratacion" + this._fecha_prestamo + "' WHERE idPrestamo=" + this._idPrestamo + ";");
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
                Sentencia.Append("DELETE FROM prestamos ");
                Sentencia.Append("WHERE idPrestamo=" + this._idPrestamo + ";");
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
