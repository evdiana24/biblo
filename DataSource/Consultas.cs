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

            String Consulta = @"SELECT m.idUsuario, m.usuario, m.clave, m.nombres, m.apellidos, m.genero, m.idRol, m.rol
            FROM 
            (SELECT a.idUsuario, a.usuario, a.clave, a.idRol, b.nombres, b.apellidos, b.genero, c.rol 
            FROM usuarios_lectores a, lectores b, roles c 
            WHERE a.idRol = c.idRol AND a.idLector = b.idLector
            UNION ALL 
            SELECT a.idUsuario, a.usuario, a.clave, a.idRol, b.nombres, b.apellidos, b.genero, c.rol 
            FROM usuarios_empleados a, empleados b, roles c 
            WHERE a.idRol = c.idRol AND a.idEmpleado = b.idEmpleado) AS m
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
            String Consulta = @"SELECT idOpcion, opcion, 
            IFNULL((SELECT idPermiso FROM permisos z WHERE z.IDROL = " + pIDRol + @" AND z.idOpcion = a.idOpcion), 0) idPermiso,
            (SELECT COUNT(IDPermiso) FROM permisos z WHERE z.IDROL = " + pIDRol + @" AND z.idOpcion = a.idOpcion) Asignado
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

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT idRol, rol FROM roles ORDER BY rol;";
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
            String Consulta = @"SELECT a.idLibro, a.titulo, a.anio_publicacion, a.edicion, a.idEditorial, b.editorial 
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

        public static DataTable TODOS_LOS_EJEMPLARES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idEjemplar, a.idLibro, b.titulo, a.estado 
            FROM ejemplares a, libros b
            WHERE a.idLibro = b.idLibro;";
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

        public static DataTable TODOS_LOS_AUTORES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idAutor, a.nombres, a.apellidos, a.genero 
            FROM autores a
            ORDER BY a.apellidos, a.nombres;";
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

        public static DataTable TODAS_LAS_CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idCategoria, a.categoria 
            FROM categorias a;";
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

        public static DataTable TODAS_LAS_EDITORIALES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idEditorial, a.editorial 
            FROM editoriales a;";
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
            String Consulta = @"SELECT a.idEmpleado, a.nombres, a.apellidos, a.fecha_nacimiento, a.dui, a.nit, a.genero, a.telefono,
            a.correo, a.direccion, a.fecha_contratacion 
            FROM empleados a
            ORDER BY a.apellidos, a.nombres;";
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

        public static DataTable TODOS_LOS_LECTORES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idLector, a.nombres, a.apellidos, a.fecha_nacimiento, a.correo, a.telefono, a.genero, a.direccion 
            FROM lectores a
            ORDER BY a.apellidos, a.nombres;";
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

        public static DataTable TODAS_LAS_MORAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idMora, a.idDetalle, a.totalMora, a.estado 
            FROM moras;";
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

        public static DataTable TODOS_LOS_PAGOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idPago, a.descripcion, a.fecha_pago, a.total, 
            a.idUsuario_lector, b.usuario AS usuarioLector, a.idUsuario_empleado, c.usuario AS usuarioEmpleado
            FROM pagos a, usuarios_lectores b, usuarios_empleados c
            WHERE a.idUsuario_lector = b.idUsuario
            AND a.idUsuario_empleado = c.idUsuario;";
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

        public static DataTable TODOS_LOS_PRESTAMOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idPrestamo, a.idUsuario_lector, b.usuario, 
            a.idUsuario_empleado, c.usuario, a.fecha_prestamo
            FROM prestamos a, usuarios_lectores b, usuarios_empleados c
            WHERE a.idUsuario_lector = b.idUsuario
            AND a.idUsuario_empleado = c.idUsuario;";
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

        public static DataTable TODOS_LOS_USUARIOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idUsuario, a.usuario, a.clave, a.estado, a.fecha_creacion, a.idEmpleado, CONCAT(b.nombres, ' ', b.apellidos) AS nombre, a.idRol, c.rol
            FROM usuarios_empleados a, empleados b, roles c
            WHERE a.idRol = c.idRol 
            AND a.idEmpleado = b.idEmpleado
            ORDER BY b.apellidos, b.nombres;";
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

        public static DataTable TODOS_LOS_USUARIOS_LECTORES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idUsuario, a.usuario, a.estado, a.carnet, a.fecha_creacion, b.idLector, CONCAT(b.nombres, ' ', b.apellidos) AS nombre
            FROM usuarios_lectores a, lectores b
            WHERE a.idLector = b.idLector
            ORDER BY nombre;";
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

