using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Lectores
    {
        String _idLector;
        String _nombres;
        String _apellidos;
        String _fecha_nacimiento;
        String _correo;
        String _telefono;
        String _genero;
        String _direccion;

        public string IdLector
        {
            get
            {
                return _idLector;
            }

            set
            {
                _idLector = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }

            set
            {
                _nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
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

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO lectores(nombres,apellidos,fecha_nacimiento,correo,telefono,genero,direccion) values(");
                Sentencia.Append("'" + this._nombres + "',");
                Sentencia.Append("'" + this._apellidos + "',");
                Sentencia.Append("'" + this._fecha_nacimiento + "',");
                Sentencia.Append("'" + this._correo + "',");
                Sentencia.Append("'" + this._telefono + "',");
                Sentencia.Append("'" + this._genero + "',");
                Sentencia.Append("'" + this._direccion + "');");

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
                Sentencia.Append("UPDATE lectores SET ");
                Sentencia.Append("nombres='" + this._nombres + "',");
                Sentencia.Append("apellidos='" + this._apellidos + "',");
                Sentencia.Append("fecha_nacimiento='" + this._fecha_nacimiento + "',");
                Sentencia.Append("correo='" + this._correo + "',");
                Sentencia.Append("telefono='" + this._telefono + "',");
                Sentencia.Append("genero='" + this._genero + "',");
                Sentencia.Append("direccion='" + this._direccion + "' ");
                Sentencia.Append("WHERE idLector=" + this._idLector + ";");
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
                Sentencia.Append("DELETE FROM lectores ");
                Sentencia.Append("WHERE idLector=" + this._idLector + ";");
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
