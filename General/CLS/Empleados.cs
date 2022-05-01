using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Empleados
    {
        String _idEmpleado;
        String _nombre;
        String _fecha_nacimiento;
        String _dui;
        String _nit;
        String _genero;
        String _telefono;
        String _correo;
        String _direccion;
        String _fecha_contratacion;

        public string IdEmpleado
        {
            get
            {
                return _idEmpleado;
            }

            set
            {
                _idEmpleado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Fecha_nacimiento
        {
            get
            {
                return _fecha_nacimiento;
            }

            set
            {
                _fecha_nacimiento = value;
            }
        }

        public string Dui
        {
            get
            {
                return _dui;
            }

            set
            {
                _dui = value;
            }
        }

        public string Nit
        {
            get
            {
                return _nit;
            }

            set
            {
                _nit = value;
            }
        }

        public string Genero
        {
            get
            {
                return _genero;
            }

            set
            {
                _genero = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Fecha_contratacion
        {
            get
            {
                return _fecha_contratacion;
            }

            set
            {
                _fecha_contratacion = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO empleados(nombre,fecha_nacimiento,dui,nit,genero,telefono,correo,direccion,fecha_contratacion) values(");
                Sentencia.Append("'" + this._nombre + "',");
                Sentencia.Append("'" + this._fecha_nacimiento + "',");
                Sentencia.Append("'" + this._dui + "',");
                Sentencia.Append("'" + this._nit + "',");
                Sentencia.Append("'" + this._genero + "',");
                Sentencia.Append("'" + this._telefono + "',");
                Sentencia.Append("'" + this._correo + "',");
                Sentencia.Append("'" + this._direccion + "',");
                Sentencia.Append("'" + this._fecha_contratacion + "');");

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
                Sentencia.Append("UPDATE empleados SET ");
                Sentencia.Append("nombre='" + this._nombre + "',");
                Sentencia.Append("fecha_nacimiento='" + this._fecha_nacimiento + "',");
                Sentencia.Append("dui='" + this._dui + "',");
                Sentencia.Append("nit='" + this._nit + "',");
                Sentencia.Append("genero='" + this._genero + "',");
                Sentencia.Append("telefono='" + this._telefono + "',");
                Sentencia.Append("correo='" + this._correo + "',");
                Sentencia.Append("direccion='" + this._direccion + "',");
                Sentencia.Append("fecha_contratacion" + this._fecha_contratacion + "' WHERE idEmpleado=" + this._idEmpleado + ";");
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
                Sentencia.Append("DELETE FROM empleados ");
                Sentencia.Append("WHERE idEmpleado=" + this._idEmpleado + ";");
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
