using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.CLS
{
    class LibrosAutores
    {
        String _idLibro_Autor;
        String _idLibro;
        String _idAutor;

        public string IdLibro_Autor
        {
            get
            {
                return _idLibro_Autor;
            }

            set
            {
                _idLibro_Autor = value;
            }
        }

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

        public string IdAutor
        {
            get
            {
                return _idAutor;
            }

            set
            {
                _idAutor = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO libros_autores(idLibro,idAutor) values(");
                Sentencia.Append("'" + this._idLibro + "',");
                Sentencia.Append("'" + this._idAutor + "');");

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
                Sentencia.Append("DELETE FROM libros_autores ");
                Sentencia.Append("WHERE idLibro_autor=" + this.IdLibro_Autor + ";");
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
