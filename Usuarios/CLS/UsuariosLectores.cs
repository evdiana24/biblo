using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.CLS
{
    class UsuariosLectores
    {
        String _IDUsuario;
        String _Usuario;
        String _Clave;
        String _Estado;
        String _Carnet;
        String _Fecha_Creacion;
        String _IDLector;
        String _IDRol;

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

        public string Carnet
        {
            get
            {
                return _Carnet;
            }

            set
            {
                _Carnet = value;
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

        public string IDLector
        {
            get
            {
                return _IDLector;
            }

            set
            {
                _IDLector = value;
            }
        }

        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO usuarios_lectores(usuario, clave, estado, carnet, fecha_creacion, idLector, idRol) values(");
                Sentencia.Append("'" + this._Usuario + "',");
                Sentencia.Append("'" + this._Clave + "',");
                Sentencia.Append("'" + this._Estado + "',");
                Sentencia.Append("'" + this._Carnet + "',");
                Sentencia.Append("'" + this._Fecha_Creacion + "',");
                Sentencia.Append("'" + this._IDLector + "',");
                Sentencia.Append("'" + this._IDRol + "');");

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
                Sentencia.Append("UPDATE usuarios_lectores SET ");
                Sentencia.Append("usuario='" + this._Usuario + "',");
                Sentencia.Append("clave='" + this._Clave + "',");
                Sentencia.Append("estado='" + this._Estado + "',");
                Sentencia.Append("carnet='" + this._Carnet + "',");
                Sentencia.Append("fecha_creacion='" + this._Fecha_Creacion + "',");
                Sentencia.Append("idLector='" + this._IDLector + "',");
                Sentencia.Append("idRol='" + this._IDRol + "' ");
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
                Sentencia.Append("DELETE FROM usuarios_lectores ");
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
