using DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.CLS
{
    class UsuariosEmpleados
    {
        String _IDUsuario;
        String _Usuario;
        String _Clave;
        String _Estado;
        String _Fecha_Creacion;
        String _IDEmpleado;
        String _IdRol;

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
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

        public string Fecha_Creacion
        {
            get
            {
                return _Fecha_Creacion;
            }

            set
            {
                _Fecha_Creacion = value;
            }
        }

        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
            }
        }

        public string IdRol
        {
            get
            {
                return _IdRol;
            }

            set
            {
                _IdRol = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO usuarios_empleados(usuario,clave,estado,fecha_creacion,idEmpleado,idRol) values(");
                Sentencia.Append("'" + this._Usuario + "',");
                Sentencia.Append("'" + Encriptacion.Encrypt(this._Clave) + "',");
                Sentencia.Append("'" + this._Estado + "',");
                Sentencia.Append("'" + this._Fecha_Creacion + "',");
                Sentencia.Append("'" + this._IDEmpleado + "',");
                Sentencia.Append("'" + this._IdRol + "');");

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
                Sentencia.Append("UPDATE usuarios_empleados SET ");
                Sentencia.Append("usuario='" + this._Usuario + "',");
                Sentencia.Append("clave='" + Encriptacion.Encrypt(this._Clave) + "',");
                Sentencia.Append("estado='" + this._Estado + "',");
                Sentencia.Append("fecha_creacion='" + this._Fecha_Creacion + "',");
                Sentencia.Append("idEmpleado='" + this._IDEmpleado + "',");
                Sentencia.Append("idRol='" + this._IdRol + "' ");
                Sentencia.Append("WHERE idUsuario=" + this._IDUsuario + ";");
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
                Sentencia.Append("DELETE FROM usuarios_empleados ");
                Sentencia.Append("WHERE idUsuario=" + this._IDUsuario + ";");
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
