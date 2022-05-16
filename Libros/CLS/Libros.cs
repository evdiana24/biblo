using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.CLS
{
    class Libros
    {
        String _idLibro;
        String _ISBN;
        String _titulo;
        String _anio_publicacion;
        String _edicion;
        String _idEditorial;

        public string IdLibro
        {
            get
            {
                return _idLibro;
            }

            set
            {
                _idLibro = value;
            }
        }

        public string ISBN
        {
            get
            {
                return _ISBN;
            }

            set
            {
                _ISBN = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public string Anio_publicacion
        {
            get
            {
                return _anio_publicacion;
            }

            set
            {
                _anio_publicacion = value;
            }
        }

        public string Edicion
        {
            get
            {
                return _edicion;
            }

            set
            {
                _edicion = value;
            }
        }

        public string IdEditorial
        {
            get
            {
                return _idEditorial;
            }

            set
            {
                _idEditorial = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO libros(ISBN,titulo,anio_publicacion,edicion,idEditorial) values(");
                Sentencia.Append("'" + this._ISBN + "',");
                Sentencia.Append("'" + this._titulo + "',");
                Sentencia.Append("'" + this._anio_publicacion + "',");
                Sentencia.Append("'" + this._edicion + "',");
                Sentencia.Append("'" + this._idEditorial + "');");

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
                Sentencia.Append("UPDATE libros SET ");
                Sentencia.Append("ISBN='" + this._ISBN + "',");
                Sentencia.Append("titulo='" + this._titulo + "',");
                Sentencia.Append("anio_publicacion='" + this._anio_publicacion + "',");
                Sentencia.Append("edicion='" + this._edicion + "',");
                Sentencia.Append("idEditorial='" + this._idEditorial + "' ");
                Sentencia.Append("WHERE idLibro=" + this._idLibro + ";");

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
                Sentencia.Append("DELETE FROM libros ");
                Sentencia.Append("WHERE idLibro=" + this._idLibro + ";");
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
