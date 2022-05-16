using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.CLS
{
    class LibrosCategorias
    {
        String _idLibro_Categoria;
        String _idLibro;
        String _idCategoria;

        public string IdLibro_Categoria
        {
            get
            {
                return _idLibro_Categoria;
            }

            set
            {
                _idLibro_Categoria = value;
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

        public string IdCategoria
        {
            get
            {
                return _idCategoria;
            }

            set
            {
                _idCategoria = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO libros_categorias(idLibro,idCategoria) values(");
                Sentencia.Append("'" + this._idLibro + "',");
                Sentencia.Append("'" + this._idCategoria + "');");

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
                Sentencia.Append("DELETE FROM libros_categorias ");
                Sentencia.Append("WHERE idLibro_categoria=" + this.IdLibro_Categoria + ";");
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
