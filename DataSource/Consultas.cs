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

            String Consulta = @"SELECT m.idUsuario, m.usuario, m.clave, m.estado, m.nombres, m.apellidos, m.genero, m.idRol, m.rol
            FROM 
            (SELECT a.idUsuario, a.usuario, a.clave, a.estado, a.idRol, b.nombres, b.apellidos, b.genero, c.rol 
            FROM usuarios_lectores a, lectores b, roles c 
            WHERE a.idRol = c.idRol AND a.idLector = b.idLector
            UNION ALL 
            SELECT a.idUsuario, a.usuario, a.clave, a.estado, a.idRol, b.nombres, b.apellidos, b.genero, c.rol 
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

        public static DataTable TODAS_LAS_OPCIONES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT idOpcion, opcion FROM opciones;";
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

            String Consulta = @"SELECT a.idLibro, a.ISBN, a.titulo, a.anio_publicacion, a.edicion, a.idEditorial, b.editorial 
            FROM libros a, editoriales b
            WHERE a.idEditorial = b.idEditorial
            ORDER BY a.idLibro DESC;";
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

        //public static DataTable TODOS_LOS_EJEPLARES_PRESTAMOS()
        //{
        //    DataTable Resultado = new DataTable();
        //    String Consulta = @"SELECT a.idLibro, a.titulo, a.anio_publicacion, a.edicion, a.idEditorial, b.editorial 
        //    FROM libros a, editoriales b
        //    WHERE a.idEditorial = b.idEditorial;";
        //    DataManager.DBOperacion op = new DataManager.DBOperacion();
        //    try
        //    {
        //        Resultado = op.Consultar(Consulta);
        //    }
        //    catch (Exception)
        //    {
        //        Resultado = new DataTable();
        //    }
        //    return Resultado;
        //}

        public static DataTable TODOS_LOS_EJEMPLARES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idEjemplar, a.idLibro, b.titulo, a.estado, a.fecha_ingreso
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

        //public static DataTable TODAS_LAS_MORAS()
        //{
        //    DataTable Resultado = new DataTable();
        //    String Consulta = @"SELECT a.idMora, a.idDetalle, a.totalMora, a.estado 
        //    FROM moras a;";
        //    DataManager.DBOperacion op = new DataManager.DBOperacion();
        //    try
        //    {
        //        Resultado = op.Consultar(Consulta);
        //    }
        //    catch (Exception)
        //    {
        //        Resultado = new DataTable();
        //    }
        //    return Resultado;
        //}

        public static DataTable TODAS_LAS_MORAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idMora, a.idDetalle, d.idEjemplar, b.titulo, c.fecha_prestamo, d.fecha_devolucion, a.totalMora, a.estado
            FROM moras a, libros b, prestamos c, detalles_prestamos d, ejemplares e
            WHERE d.idEjemplar = e.idEjemplar
            AND b.idLibro = e.idLibro
            AND a.idDetalle = d.idDetalle
            AND c.idPrestamo = d.idPrestamo;";
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
            AND a.idUsuario_empleado = c.idUsuario
            ORDER BY a.idPago DESC;";
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
            String Consulta = @"SELECT a.idPrestamo, a.idUsuario_lector, b.usuario AS usuario_lector, 
            a.idUsuario_empleado, c.usuario AS usuario_empleado, a.fecha_prestamo
            FROM prestamos a, usuarios_lectores b, usuarios_empleados c
            WHERE a.idUsuario_lector = b.idUsuario
            AND a.idUsuario_empleado = c.idUsuario
            ORDER BY a.idPrestamo DESC;";
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

        public static DataTable DATOS_EMPLEADO(String pIDUsuario)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT CONCAT(a.nombres, ' ', a.apellidos) AS nombre, a.fecha_nacimiento, 
            a.dui, a.nit, a.genero, a.telefono, a.correo, a.direccion, a.fecha_contratacion, b.usuario, b.fecha_creacion, c.rol
            FROM empleados a, usuarios_empleados b, roles c
            WHERE a.idEmpleado = b.idEmpleado AND b.idRol = c.idRol AND b.idUsuario = " + pIDUsuario + ";";

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

        public static DataTable DATOS_LECTOR(String pIDUsuario)
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT CONCAT(a.nombres, ' ', a.apellidos) AS nombre, a.fecha_nacimiento, 
            a.genero, a.telefono, a.correo, a.direccion, b.usuario, b.fecha_creacion, b.carnet, c.rol
            FROM lectores a, usuarios_lectores b, roles c
            WHERE a.idLector = b.idLector AND b.idRol = c.idRol AND b.idUsuario = " + pIDUsuario + ";";

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

        public static DataTable TODOS_LOS_EJEMPLARES_DISPONIBLES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idEjemplar, b.titulo, d.categoria, CONCAT(f.nombres, ' ', f.apellidos) AS autor, g.editorial
            FROM ejemplares a, libros b, libros_categorias c, categorias d, libros_autores e, autores f, editoriales g
            WHERE a.idLibro = b.idLibro AND c.idCategoria = d.idCategoria AND c.idLibro = b.idLibro AND e.idAutor = f.idAutor 
            AND e.idLibro = b.idLibro AND g.idEditorial = b.idEditorial AND a.estado = 'DISPONIBLE' GROUP BY a.idEjemplar;";
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

        public static DataTable BUSCAR_LIBRO()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idLibro, a.titulo, a.anio_publicacion, a.edicion, CONCAT(b.nombres, ' ',b.apellidos) AS autor, 
            c.categoria, f.editorial, (SELECT IFNULL(COUNT(g.idLibro), 0) FROM ejemplares g WHERE estado = 'DISPONIBLE' AND g.idLibro = a.idLibro) AS ejemplares
            FROM libros a, autores b, categorias c, libros_categorias d, libros_autores e, editoriales f
            WHERE b.idAutor = e.idAutor
            AND e.idLibro = a.idLibro
            AND c.idCategoria = d.idCategoria
            AND d.idLibro = a.idLibro
            AND f.idEditorial = a.idEditorial
            GROUP BY a.idLibro;";
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

        public static DataTable DETALLES_POR_ID_PRESTAMO(String pIDPrestamo)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idDetalle, a.idPrestamo, a.idEjemplar AS idEjemplarDetalle, c.titulo AS tituloDetalle, a.fecha_devolucion
            FROM detalles_prestamos a, ejemplares b, libros c
            WHERE a.idEjemplar = b.idEjemplar AND b.idLibro = c.idLibro AND a.idPrestamo = " + pIDPrestamo + ";";

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

        public static DataTable AUTORES_POR_ID_LIBRO(String pIDLibro)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT b.idLibro_autor, a.idAutor AS idAutorAgregado, CONCAT(a.nombres, ' ', a.apellidos) AS autorAgregado
            FROM autores a, libros_autores b
            WHERE a.idAutor = b.idAutor
            AND b.idLibro = " + pIDLibro + ";";

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

        public static DataTable CATEGORIAS_POR_ID_LIBRO(String pIDLibro)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idLibro_categoria, a.idCategoria AS idCategoriaAgregada, b.categoria AS categoriaAgregada
            FROM libros_categorias a, categorias b, libros c
            WHERE a.idLibro = c.idLibro
            AND a.idCategoria = b.idCategoria
            AND a.idLibro = " + pIDLibro + ";";

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

        public static DataTable MIS_PRESTAMOS(String pIDUsuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT c.titulo, f.categoria, CONCAT(h.nombres, ' ', h.apellidos) AS autor, i.editorial, a.fecha_prestamo, b.fecha_devolucion
            FROM prestamos a, detalles_prestamos b, libros c, ejemplares d, libros_categorias e, categorias f, libros_autores g, autores h, editoriales i
            WHERE a.idPrestamo = b.idPrestamo
            AND b.idEjemplar = d.idEjemplar
            AND c.idLibro = d.idLibro
            AND e.idCategoria = f.idCategoria
            AND e.idLibro = c.idLibro
            AND g.idAutor = h.idAutor
            AND c.idLibro = g.idLibro
            AND c.idEditorial = i.idEditorial
            AND a.idUsuario_lector = " + pIDUsuario + @"
            ORDER BY a.fecha_prestamo;";

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

        public static DataTable HISTORIAL_PAGOS(String pIDUsuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT descripcion, fecha_pago, total FROM 
            pagos
            WHERE idUsuario_lector = " + pIDUsuario + ";";

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

        //public static DataTable LIBROS_AUTORES(String pIDLibro)
        //{
        //    DataTable Resultado = new DataTable();
        //    String Consulta = @"SELECT a.idAutor, a.nombres, a.apellidos, a.genero 
        //    FROM autores a
        //    WHERE a.idAutor NOT IN (SELECT idAutor FROM libros_autores WHERE idLibro = " + pIDLibro + @"')
        //    ORDER BY a.apellidos, a.nombres;";

        //    DataManager.DBOperacion op = new DataManager.DBOperacion();
        //    try
        //    {
        //        Resultado = op.Consultar(Consulta);
        //    }
        //    catch (Exception)
        //    {
        //        Resultado = new DataTable();
        //    }
        //    return Resultado;
        //}

        public static DataTable MIS_MORAS(String pIDUsuario)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT b.titulo, c.fecha_prestamo, d.fecha_devolucion, a.totalMora, a.estado
            FROM moras a, libros b, prestamos c, detalles_prestamos d, ejemplares e
            WHERE d.idEjemplar = e.idEjemplar
            AND b.idLibro = e.idLibro
            AND a.idDetalle = d.idDetalle
            AND c.idPrestamo = d.idPrestamo
            AND a.estado = 'PENDIENTE'
            AND c.idUsuario_lector = " + pIDUsuario + ";";

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

        public static DataTable TODAS_LAS_DEVOLUCIONES()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idDevolucion, a.idDetalle, a.condicion_libro, a.descripcion, a.fecha_entregado 
            FROM devoluciones a
            ORDER BY a.idDevolucion DESC;";
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

        public static DataTable TODOS_LOS_DETALLES_PRESTAMOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idDetalle, a.idPrestamo, CONCAT(d.nombres, ' ', d.apellidos) AS lector, a.idEjemplar, b.titulo, f.fecha_prestamo, a.fecha_devolucion
            FROM detalles_prestamos a, libros b, ejemplares c, lectores d, usuarios_lectores e, prestamos f
            WHERE b.idLibro = c.idLibro
            AND a.idEjemplar = c.idEjemplar
            AND f.idPrestamo = a.idPrestamo
            AND f.idUsuario_lector = e.idUsuario
            AND e.idLector = d.idLector 
            ORDER BY a.idDetalle DESC;";
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
        public static DataTable REPORTE_PAGOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idPago, a.descripcion, a.total, b.usuario as empleado, c.usuario as lector, a.fecha_pago
                                FROM biblioteca2.pagos a, biblioteca2.usuarios_empleados b, usuarios_lectores c
                                WHERE a.idPago = b.idEmpleado
                                AND a.idPago = c.idLector;";
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
        public static DataTable REPORTE_MORAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idMora, a.totalMora, a.estado, b.fecha_devolucion, d.usuario as lector
                                FROM biblioteca2.moras a, detalles_prestamos b, prestamos c, usuarios_lectores d
                                WHERE a.idDetalle = b.idDetalle
                                AND a.idDetalle = c.idPrestamo
                                GROUP BY a.idMora;";
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
        public static DataTable REPORTE_LIBROS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT b.idLibro,  b.ISBN, b.titulo, d.categoria, CONCAT(f.nombres, ' ', f.apellidos) AS autor, g.editorial,
                                COUNT(a.idEjemplar) AS cantidad
                                FROM ejemplares a, libros b, libros_categorias c, categorias d, libros_autores e, autores f, editoriales g
                                WHERE a.idLibro = b.idLibro AND c.idCategoria = d.idCategoria AND c.idLibro = b.idLibro AND e.idAutor = f.idAutor 
                                AND e.idLibro = b.idLibro AND g.idEditorial = b.idEditorial
                                group by a.idLibro;";
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
        public static DataTable REPORTE_PRESTAMOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT a.idPrestamo, e.idDetalle, g.titulo, a.fecha_prestamo, b.usuario AS Usuario_lector, e.fecha_devolucion
                                FROM prestamos a, usuarios_lectores b, ejemplares f, libros g, detalles_prestamos e
                                WHERE a.idUsuario_lector = b.idUsuario
                                AND a.idPrestamo = e.idPrestamo
                                AND e.idEjemplar = f.idEjemplar
                                AND g.idLibro = f.idLibro
                                ORDER BY a.fecha_prestamo;";
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

