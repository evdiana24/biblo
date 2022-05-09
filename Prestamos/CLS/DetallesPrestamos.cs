using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.CLS
{
    class DetallesPrestamos
    {
        String _idDetalle;
        String _idPrestamo;
        String _idEjemplar;
        String _fecha_devolucion;

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

        public string IdEjemplar
        {
            get
            {
                return _idEjemplar;
            }

            set
            {
                _idEjemplar = value;
            }
        }

        public string Fecha_devolucion
        {
            get
            {
                return _fecha_devolucion;
            }

            set
            {
                _fecha_devolucion = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO detalles_prestamos(idPrestamo,idEjemplar,fecha_devolucion) values(");
                Sentencia.Append("'" + this._idPrestamo + "',");
                Sentencia.Append("'" + this._idEjemplar + "',");
                Sentencia.Append("'" + this._fecha_devolucion + "');");

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

        //public Boolean Actualizar()
        //{
        //    Boolean Resultado = false;
        //    StringBuilder Sentencia = new StringBuilder();
        //    DataManager.DBOperacion operacion = new DataManager.DBOperacion();
        //    try
        //    {
        //        Sentencia.Append("UPDATE prestamos_detalles SET ");
        //        Sentencia.Append("idDetalle='" + this._idDetalle + "',");
        //        Sentencia.Append("idPrestamo='" + this._idPrestamo + "',");
        //        Sentencia.Append("idEjemplar='" + this._idEjemplar + "',");
        //        Sentencia.Append("fecha_prestamo" + this._fecha_devolucion + "' WHERE idDetalle=" + this.IdDetalle + ";");
        //        if (operacion.Actualizar(Sentencia.ToString()) > 0)
        //        {
        //            Resultado = true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Resultado = false;
        //    }
        //    return Resultado;
        //}

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM detalles_prestamos ");
                Sentencia.Append("WHERE idDetalle=" + this.IdDetalle + ";");
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
