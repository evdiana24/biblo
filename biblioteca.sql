-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: biblioteca
-- ------------------------------------------------------
-- Server version	5.7.36-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `all_users`
--

DROP TABLE IF EXISTS `all_users`;
/*!50001 DROP VIEW IF EXISTS `all_users`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `all_users` AS SELECT 
 1 AS `idUsuario`,
 1 AS `usuario`,
 1 AS `clave`,
 1 AS `nombre`,
 1 AS `genero`,
 1 AS `idRol`,
 1 AS `rol`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `autores`
--

DROP TABLE IF EXISTS `autores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autores` (
  `idAutor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  PRIMARY KEY (`idAutor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autores`
--

LOCK TABLES `autores` WRITE;
/*!40000 ALTER TABLE `autores` DISABLE KEYS */;
/*!40000 ALTER TABLE `autores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `idCategoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `categoria` varchar(50) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalles_prestamos`
--

DROP TABLE IF EXISTS `detalles_prestamos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalles_prestamos` (
  `idDetalle` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idPrestamo` int(10) unsigned NOT NULL,
  `idEjemplar` int(10) unsigned NOT NULL,
  `fecha_devolucion` datetime NOT NULL,
  PRIMARY KEY (`idDetalle`),
  KEY `fk_Detalles_Prestamos_Prestamos1_idx` (`idPrestamo`),
  KEY `fk_Detalles_Prestamos_Ejemplares1_idx` (`idEjemplar`),
  CONSTRAINT `fk_Detalles_Prestamos_Ejemplares1` FOREIGN KEY (`idEjemplar`) REFERENCES `ejemplares` (`idEjemplar`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detalles_Prestamos_Prestamos1` FOREIGN KEY (`idPrestamo`) REFERENCES `prestamos` (`idPrestamo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles_prestamos`
--

LOCK TABLES `detalles_prestamos` WRITE;
/*!40000 ALTER TABLE `detalles_prestamos` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles_prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `editoriales`
--

DROP TABLE IF EXISTS `editoriales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `editoriales` (
  `idEditorial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `editorial` varchar(50) NOT NULL,
  PRIMARY KEY (`idEditorial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editoriales`
--

LOCK TABLES `editoriales` WRITE;
/*!40000 ALTER TABLE `editoriales` DISABLE KEYS */;
/*!40000 ALTER TABLE `editoriales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ejemplares`
--

DROP TABLE IF EXISTS `ejemplares`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ejemplares` (
  `idEjemplar` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idLibro` int(10) unsigned NOT NULL,
  `estado` enum('DISPONIBLE','NO DISPONIBLE') NOT NULL,
  PRIMARY KEY (`idEjemplar`),
  KEY `fk_Ejemplares_Libros1_idx` (`idLibro`),
  CONSTRAINT `fk_Ejemplares_Libros1` FOREIGN KEY (`idLibro`) REFERENCES `libros` (`idLibro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ejemplares`
--

LOCK TABLES `ejemplares` WRITE;
/*!40000 ALTER TABLE `ejemplares` DISABLE KEYS */;
/*!40000 ALTER TABLE `ejemplares` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idEmpleado` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `dui` varchar(10) NOT NULL,
  `nit` varchar(15) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  `telefono` varchar(8) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `direccion` varchar(150) NOT NULL,
  `fecha_contratacion` datetime NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Nestor Cienfuegos','1985-10-12','12345672-1','0315-121085-123','MASCULINO','78912200','nestor@gmail.com','Sonsonate.','2021-01-15 00:00:00');
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lectores`
--

DROP TABLE IF EXISTS `lectores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lectores` (
  `idLector` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `correo` varchar(50) NOT NULL,
  `telefono` varchar(8) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  `direccion` varchar(150) NOT NULL,
  PRIMARY KEY (`idLector`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lectores`
--

LOCK TABLES `lectores` WRITE;
/*!40000 ALTER TABLE `lectores` DISABLE KEYS */;
INSERT INTO `lectores` VALUES (1,'Diana Bonilla','1999-09-24','diana@gmail.com','77777777','FEMENINO','Sonsonate.');
/*!40000 ALTER TABLE `lectores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros`
--

DROP TABLE IF EXISTS `libros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libros` (
  `idLibro` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `titulo` varchar(100) NOT NULL,
  `anio_publicacion` int(11) NOT NULL,
  `edicion` int(10) unsigned NOT NULL,
  `idEditorial` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idLibro`),
  KEY `fk_Libros_Editoriales1_idx` (`idEditorial`),
  CONSTRAINT `fk_Libros_Editoriales1` FOREIGN KEY (`idEditorial`) REFERENCES `editoriales` (`idEditorial`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
/*!40000 ALTER TABLE `libros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros_autores`
--

DROP TABLE IF EXISTS `libros_autores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libros_autores` (
  `idLibro_autor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idLibro` int(10) unsigned NOT NULL,
  `idAutor` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idLibro_autor`),
  KEY `fk_Libros_Autores_Libros1_idx` (`idLibro`),
  KEY `fk_Libros_Autores_Autores1_idx` (`idAutor`),
  CONSTRAINT `fk_Libros_Autores_Autores1` FOREIGN KEY (`idAutor`) REFERENCES `autores` (`idAutor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libros_Autores_Libros1` FOREIGN KEY (`idLibro`) REFERENCES `libros` (`idLibro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros_autores`
--

LOCK TABLES `libros_autores` WRITE;
/*!40000 ALTER TABLE `libros_autores` DISABLE KEYS */;
/*!40000 ALTER TABLE `libros_autores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros_categorias`
--

DROP TABLE IF EXISTS `libros_categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libros_categorias` (
  `idLibro_categoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idLibro` int(10) unsigned NOT NULL,
  `idCategoria` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idLibro_categoria`),
  KEY `fk_Libros_Categorias_Categorias1_idx` (`idCategoria`),
  KEY `fk_Libros_Categorias_Libros1_idx` (`idLibro`),
  CONSTRAINT `fk_Libros_Categorias_Categorias1` FOREIGN KEY (`idCategoria`) REFERENCES `categorias` (`idCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libros_Categorias_Libros1` FOREIGN KEY (`idLibro`) REFERENCES `libros` (`idLibro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros_categorias`
--

LOCK TABLES `libros_categorias` WRITE;
/*!40000 ALTER TABLE `libros_categorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `libros_categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moras`
--

DROP TABLE IF EXISTS `moras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `moras` (
  `idMora` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idDetalle` int(10) unsigned NOT NULL,
  `totalMora` decimal(5,2) NOT NULL,
  `estado` enum('PENDIENTE','CANCELADA') NOT NULL,
  PRIMARY KEY (`idMora`),
  KEY `fk_Moras_Detalles_Prestamos1_idx` (`idDetalle`),
  CONSTRAINT `fk_Moras_Detalles_Prestamos1` FOREIGN KEY (`idDetalle`) REFERENCES `detalles_prestamos` (`idDetalle`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moras`
--

LOCK TABLES `moras` WRITE;
/*!40000 ALTER TABLE `moras` DISABLE KEYS */;
/*!40000 ALTER TABLE `moras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opciones` (
  `idOpcion` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `opcion` varchar(50) NOT NULL,
  PRIMARY KEY (`idOpcion`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'INICIAR SESION'),(2,'GESTION DE USUARIOS'),(3,'GESTION DE PERMISOS'),(4,'GESTION DE LIBROS'),(5,'GESTION DE AUTORES'),(6,'GESTION DE PAGOS');
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `idPago` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` enum('PAGO DE MORA','REPOSICIÓN DE LIBRO','DAÑO DE LIBRO','DONACIÓN','REPOSICIÓN DE CARNET') NOT NULL,
  `fecha_pago` datetime NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `idUsuario_lector` int(10) unsigned NOT NULL,
  `idUsuario_empleado` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `fk_pagos_usuarios_empleados1_idx` (`idUsuario_empleado`),
  KEY `fk_pagos_usuarios_lectores1_idx` (`idUsuario_lector`),
  CONSTRAINT `fk_pagos_usuarios_empleados1` FOREIGN KEY (`idUsuario_empleado`) REFERENCES `usuarios_empleados` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_pagos_usuarios_lectores1` FOREIGN KEY (`idUsuario_lector`) REFERENCES `usuarios_lectores` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `idPermiso` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idRol` int(10) unsigned NOT NULL,
  `idOpcion` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idPermiso`),
  KEY `fk_Permisos_Roles1_idx` (`idRol`),
  KEY `fk_Permisos_Opciones1_idx` (`idOpcion`),
  CONSTRAINT `fk_Permisos_Opciones1` FOREIGN KEY (`idOpcion`) REFERENCES `opciones` (`idOpcion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Permisos_Roles1` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,2,1),(2,2,2),(3,2,3),(4,2,4);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamos`
--

DROP TABLE IF EXISTS `prestamos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prestamos` (
  `idPrestamo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idUsuario_lector` int(10) unsigned NOT NULL,
  `idUsuario_empleado` int(10) unsigned NOT NULL,
  `fecha_prestamo` datetime NOT NULL,
  PRIMARY KEY (`idPrestamo`),
  KEY `fk_prestamos_usuarios_lectores1_idx` (`idUsuario_lector`),
  KEY `fk_prestamos_usuarios_empleados1_idx` (`idUsuario_empleado`),
  CONSTRAINT `fk_prestamos_usuarios_empleados1` FOREIGN KEY (`idUsuario_empleado`) REFERENCES `usuarios_empleados` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_prestamos_usuarios_lectores1` FOREIGN KEY (`idUsuario_lector`) REFERENCES `usuarios_lectores` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos`
--

LOCK TABLES `prestamos` WRITE;
/*!40000 ALTER TABLE `prestamos` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRol` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `rol` varchar(45) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'LECTOR'),(2,'ADMINISTRADOR');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios_empleados`
--

DROP TABLE IF EXISTS `usuarios_empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios_empleados` (
  `idUsuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `estado` enum('ACTIVO','SUSPENDIDO') NOT NULL,
  `fecha_creación` datetime NOT NULL,
  `idEmpleado` int(10) unsigned NOT NULL,
  `idRol` varchar(45) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  KEY `fk_Usuarios_Empleados_Empleados1_idx` (`idEmpleado`),
  CONSTRAINT `fk_Usuarios_Empleados_Empleados1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_empleados`
--

LOCK TABLES `usuarios_empleados` WRITE;
/*!40000 ALTER TABLE `usuarios_empleados` DISABLE KEYS */;
INSERT INTO `usuarios_empleados` VALUES (1,'nestor@admin','12345','ACTIVO','2021-01-16 00:00:00',1,'2');
/*!40000 ALTER TABLE `usuarios_empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios_lectores`
--

DROP TABLE IF EXISTS `usuarios_lectores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios_lectores` (
  `idUsuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `clave` varchar(45) NOT NULL,
  `estado` enum('ACTIVO','SUSPENDIDO') NOT NULL,
  `carnet` enum('VERDADERO','FALSO') NOT NULL,
  `fecha_creacion` datetime NOT NULL,
  `idLector` int(10) unsigned NOT NULL,
  `idRol` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  KEY `fk_usuarios_lectores_lectores1_idx` (`idLector`),
  KEY `fk_usuarios_lectores_roles1_idx` (`idRol`),
  CONSTRAINT `fk_usuarios_lectores_lectores1` FOREIGN KEY (`idLector`) REFERENCES `lectores` (`idLector`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarios_lectores_roles1` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_lectores`
--

LOCK TABLES `usuarios_lectores` WRITE;
/*!40000 ALTER TABLE `usuarios_lectores` DISABLE KEYS */;
INSERT INTO `usuarios_lectores` VALUES (1,'Diana24','12345','ACTIVO','VERDADERO','2022-03-17 00:00:00',1,1);
/*!40000 ALTER TABLE `usuarios_lectores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `all_users`
--

/*!50001 DROP VIEW IF EXISTS `all_users`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `all_users` AS select `m`.`idUsuario` AS `idUsuario`,`m`.`usuario` AS `usuario`,`m`.`clave` AS `clave`,`m`.`nombre` AS `nombre`,`m`.`genero` AS `genero`,`m`.`idRol` AS `idRol`,`m`.`rol` AS `rol` from (select `a`.`idUsuario` AS `idUsuario`,`a`.`usuario` AS `usuario`,`a`.`clave` AS `clave`,`a`.`idRol` AS `idRol`,`b`.`nombre` AS `nombre`,`b`.`genero` AS `genero`,`c`.`rol` AS `rol` from ((`biblioteca`.`usuarios_lectores` `a` join `biblioteca`.`lectores` `b`) join `biblioteca`.`roles` `c`) where ((`a`.`idRol` = `c`.`idRol`) and (`a`.`idLector` = `b`.`idLector`)) union all select `a`.`idUsuario` AS `idUsuario`,`a`.`usuario` AS `usuario`,`a`.`clave` AS `clave`,`a`.`idRol` AS `idRol`,`b`.`nombre` AS `nombre`,`b`.`genero` AS `genero`,`c`.`rol` AS `rol` from ((`biblioteca`.`usuarios_empleados` `a` join `biblioteca`.`empleados` `b`) join `biblioteca`.`roles` `c`) where ((`a`.`idRol` = `c`.`idRol`) and (`a`.`idEmpleado` = `b`.`idEmpleado`))) `m` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-18  4:36:27
