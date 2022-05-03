using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSource
{
    public static class Consultas
    {
        public static DataTable INICIO_SESION(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
    
            String Consulta = @"SELECT m.idUsuario, m.usuario, m.clave, m.nombre, m.genero, m.idRol, m.rol
            FROM 
            (SELECT a.idUsuario, a.usuario, a.clave, a.idRol, b.nombre, b.genero, c.rol FROM usuarios_lectores a, lectores b, roles c WHERE a.idRol = c.idRol AND a.idLector = b.idLector
            UNION ALL 
            SELECT a.idUsuario, a.usuario, a.clave, a.idRol, b.nombre, b.genero, c.rol FROM usuarios_empleados a, empleados b, roles c WHERE a.idRol = c.idRol AND a.idEmpleado = b.idEmpleado) AS m
            WHERE usuario = '" + pUsuario + @"'
            AND clave = '" + pClave + "';";

            DataManager.DBOperacion op = new DataManager.DBOperacion();

            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable PERMISOS(String pIDRol)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT idOpcion, 
            (SELECT opcion FROM opciones z WHERE z.idOpcion = a.idOpcion) Opcion 
            FROM permisos a WHERE idROl = " + pIDRol + ";";

            DataManager.DBOperacion op = new DataManager.DBOperacion();

            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable PERMISOS_DE_UN_ROL(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDOpcion, Opcion, 
            IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDROL = " + pIDRol + @" AND z.IDOpcion = a.IDOpcion), 0) IDPermiso,
            (SELECT COUNT(IDPermiso) FROM permisos z WHERE z.IDROL = " + pIDRol + @" AND z.IDOpcion = a.IDOpcion) Asignado
            FROM opciones a;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable TODOS_LOS_LIBROS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idLibro, a.titulo, a.anio_publicacion, a.edicion, b.editorial 
            FROM libros a, editoriales b
            WHERE a.idEditorial = b.idEditorial;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, Genero 
            FROM empleados order by Apellidos, Nombres;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDRol, Rol FROM roles ORDER BY Rol;";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}

