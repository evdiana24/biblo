-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: biblofinal
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
-- Table structure for table `autores`
--

DROP TABLE IF EXISTS `autores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autores` (
  `idAutor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombres` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  PRIMARY KEY (`idAutor`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autores`
--

LOCK TABLES `autores` WRITE;
/*!40000 ALTER TABLE `autores` DISABLE KEYS */;
INSERT INTO `autores` VALUES (1,'Fischer ','de la Vega','MASCULINO'),(2,'Rosendo','Berenguí Gil','MASCULINO'),(3,'Álvaro','Gómez Vieites','MASCULINO'),(4,'Nancy','Morgan','FEMENINO'),(5,'Ricardo','Hoyos Ballesteros','MASCULINO'),(6,'Javier','Casanoves Boix','MASCULINO'),(7,'Gabriel José','García Márquez','MASCULINO'),(9,'Jojo','Mojes','FEMENINO'),(10,'Joanne ','Rowling','FEMENINO'),(11,'Stephen Edwin ','King','MASCULINO'),(12,'Joyanes','Aguilar','MASCULINO'),(13,'Francisco','Javier','MASCULINO'),(14,'Ian ','Sommerville','MASCULINO'),(15,'María Guadalupe','Mendoza García','FEMENINO'),(16,'William','Martinez','MASCULINO');
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Poesía'),(2,'Historia'),(3,'Ciencias naturales'),(4,'Novela'),(5,'Novela Gótica'),(6,'Economía'),(7,'Novela detectivesca'),(8,'Romanticismo'),(9,'Ingeniería'),(10,'Terror'),(11,'Ciencia ficción');
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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles_prestamos`
--

LOCK TABLES `detalles_prestamos` WRITE;
/*!40000 ALTER TABLE `detalles_prestamos` DISABLE KEYS */;
INSERT INTO `detalles_prestamos` VALUES (2,2,2,'2022-05-12 00:00:00'),(3,1,1,'2022-05-11 00:00:00'),(4,1,1,'2022-05-11 00:00:00'),(5,1,1,'2022-05-11 00:00:00'),(8,2,1,'2022-05-11 00:00:00'),(9,1,1,'2022-05-11 00:00:00'),(10,1,2,'2022-05-11 00:00:00'),(11,2,3,'2022-05-11 00:00:00'),(12,3,4,'2022-05-17 00:00:00'),(13,3,5,'2022-05-18 00:00:00'),(15,4,6,'2022-05-23 00:00:00');
/*!40000 ALTER TABLE `detalles_prestamos` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER RestriccionCantidad
BEFORE INSERT ON detalles_prestamos
FOR EACH ROW
BEGIN
  IF (SELECT COUNT(idPrestamo) AS cantidad 
            FROM detalles_prestamos
            WHERE idPrestamo = NEW.idPrestamo) = 5
  THEN 
   SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'NO ES POSIBLE PRESTAR MÁS DE 5 EJEMPLARES.';
  END IF;
  END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER estadoLibro_AgregarDetalle
AFTER INSERT ON detalles_prestamos 
FOR EACH ROW
BEGIN 
	UPDATE ejemplares SET estado = 'NO DISPONIBLE' WHERE idEjemplar = NEW.idEjemplar;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER estadoLibro_EliminarDetalle
AFTER DELETE ON detalles_prestamos 
FOR EACH ROW
BEGIN 
	UPDATE ejemplares SET estado = 'DISPONIBLE' WHERE idEjemplar = OLD.idEjemplar;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devoluciones` (
  `idDevolucion` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idDetalle` int(10) unsigned NOT NULL,
  `condicion_libro` enum('BUENA','DAÑADO') NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `fecha_entregado` datetime NOT NULL,
  PRIMARY KEY (`idDevolucion`),
  KEY `fk_devoluciones_detalles_prestamos1_idx` (`idDetalle`),
  CONSTRAINT `fk_devoluciones_detalles_prestamos1` FOREIGN KEY (`idDetalle`) REFERENCES `detalles_prestamos` (`idDetalle`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devoluciones`
--

LOCK TABLES `devoluciones` WRITE;
/*!40000 ALTER TABLE `devoluciones` DISABLE KEYS */;
INSERT INTO `devoluciones` VALUES (1,2,'BUENA',NULL,'2022-03-12 00:00:00'),(2,2,'DAÑADO','Mancha en la página 78.','2022-05-14 10:01:41'),(3,15,'BUENA','','2022-05-23 13:18:13');
/*!40000 ALTER TABLE `devoluciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER validarDevolucion
BEFORE INSERT ON devoluciones 
FOR EACH ROW
BEGIN 
	IF (NEW.idDetalle IN (SELECT idDetalle FROM devoluciones))
	THEN 
	SIGNAL SQLSTATE '45012' SET MESSAGE_TEXT = 'LA DEVOLUCION YA FUE PREVIAMENTE REGISTRADA.';
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editoriales`
--

LOCK TABLES `editoriales` WRITE;
/*!40000 ALTER TABLE `editoriales` DISABLE KEYS */;
INSERT INTO `editoriales` VALUES (1,'Editorial Sudamericana'),(2,'El conquistador'),(3,'McGraw Hill'),(4,'ECOE Ediciones'),(5,'CROSSBOOKS'),(6,'Nórdica'),(7,'Blackie Books'),(8,'Ático de los libros'),(9,'Hiperión'),(10,'Editorial Mirahadas');
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
  `fecha_ingreso` datetime NOT NULL,
  PRIMARY KEY (`idEjemplar`),
  KEY `fk_Ejemplares_Libros1_idx` (`idLibro`),
  CONSTRAINT `fk_Ejemplares_Libros1` FOREIGN KEY (`idLibro`) REFERENCES `libros` (`idLibro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ejemplares`
--

LOCK TABLES `ejemplares` WRITE;
/*!40000 ALTER TABLE `ejemplares` DISABLE KEYS */;
INSERT INTO `ejemplares` VALUES (1,1,'DISPONIBLE','2022-03-01 00:00:00'),(2,1,'DISPONIBLE','2022-03-01 00:00:00'),(3,2,'DISPONIBLE','2022-03-01 00:00:00'),(4,4,'NO DISPONIBLE','2022-03-01 00:00:00'),(5,3,'DISPONIBLE','2022-03-01 00:00:00'),(6,7,'NO DISPONIBLE','2022-05-23 13:09:51'),(7,7,'DISPONIBLE','2022-05-23 13:09:51');
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
  `nombres` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `dui` varchar(10) NOT NULL,
  `nit` varchar(17) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  `telefono` varchar(8) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `direccion` varchar(150) NOT NULL,
  `fecha_contratacion` varchar(100) NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Evelin ','Bonilla','1999-09-24','00112345','0315-240999-1','FEMENINO','76547223','evdiana@gmail.com','Col. America, Sonsonate.','2022-03-01'),(2,'Nestor Gilberto','Cienfuegos Caceres','1985-07-04','12345','0315-020185-1','MASCULINO','12345','nestor@hotmail.com','Col. Sensunapan','2022/03/03'),(3,'María Lidia ','Peña Cortez','1994-05-05','123456','123456','FEMENINO','77091234','marli@yahoo.com','Col. Santa Marta, Sonsonate.','2022/05/03'),(4,'Sofia ','Perez','1999-02-02','12345','12345','FEMENINO','3456','sofigarzona@gmail.com','Col. 14 de dic., Sonsonate.','2022/05/06'),(5,'Gabriela María','Vanegas González','2000-03-28','06037918-3','0315-280300-103-6','FEMENINO','74184891','gaby@gmail.com','Barrio El Angel, pasaje El progreso, Sonsonate.','2022/01/12'),(6,'Alexis Leodan','Bonilla Rivera','2006-02-26','12345678-9','0315-130206-102-1','MASCULINO','77771111','alexis@hotmail.com','Col. Angélica. Sonsonate','2022/05/23');
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
  `nombres` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `correo` varchar(100) NOT NULL,
  `telefono` varchar(8) NOT NULL,
  `genero` enum('FEMENINO','MASCULINO') NOT NULL,
  `direccion` varchar(150) NOT NULL,
  PRIMARY KEY (`idLector`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lectores`
--

LOCK TABLES `lectores` WRITE;
/*!40000 ALTER TABLE `lectores` DISABLE KEYS */;
INSERT INTO `lectores` VALUES (1,'Gabriela','Vanegas','2000-03-28','gaby@yahoo.com','76890143','FEMENINO','Barrio El Pilar, Sonsonate.'),(3,'Manuel ','García','1999-07-14','mgarcia@gmail.com','77889922','MASCULINO','Col. El Balsamar, Sonsonate.'),(4,'Lorena ','Morena','1994-02-08','loremore@gmail.com','79800011','FEMENINO','Barrio El Angel'),(5,'Erick Roberto','Chacón Chicas','2000-05-23','erick@yahoo.com','78090011','MASCULINO','Acajutla, Sonsonate.');
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
  `ISBN` varchar(17) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `anio_publicacion` int(11) NOT NULL,
  `edicion` int(10) unsigned NOT NULL,
  `idEditorial` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idLibro`),
  KEY `fk_Libros_Editoriales1_idx` (`idEditorial`),
  CONSTRAINT `fk_Libros_Editoriales1` FOREIGN KEY (`idEditorial`) REFERENCES `editoriales` (`idEditorial`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
INSERT INTO `libros` VALUES (1,'978-92-95055-02-5','Cien años de soledad',1967,1,1),(2,'978-02-95155-02-6','Aventuras Extraordinarias',1843,1,1),(3,'778-12-91088-02-5','Las aventuras de Sherlock Holmes',1974,1,2),(4,'111-02-48325-02-5','Ingeniería Económica',1991,7,3),(5,'987-65-43210-98-7','Imperios y Espadazos',2019,1,2),(6,'111-11-11111-11-1','Prueba',2000,4,3),(7,'111-11-22222-33-5','Yo antes de ti',2017,1,3),(8,'978-84-663-5979-5','La última carta de amor',2021,1,5),(9,'978-84-663-5731-9','El resplandor',2021,1,6),(10,'978-84-18173-00-4','Harry Potter y la piedra filosofal',2020,1,7),(11,'894-89-9521-55-6','Fundamentos generales de programación',2013,1,8),(12,'659-36-44864-85-9','Contabilidad 1',2011,1,9),(13,'451-23-18454-63-4','Ingeniería de software',2011,4,10),(14,'126-14-15684-41-3','Teoría de autómatas',2015,1,5),(15,'638-85-15684-74-8','Tertulias con olor a café',2019,1,6);
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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros_autores`
--

LOCK TABLES `libros_autores` WRITE;
/*!40000 ALTER TABLE `libros_autores` DISABLE KEYS */;
INSERT INTO `libros_autores` VALUES (2,2,2),(3,4,3),(4,4,4),(8,6,5),(9,1,1),(10,3,5),(11,7,9),(12,8,9),(13,9,11),(14,10,10),(15,11,12),(16,12,13),(17,13,14),(18,14,15),(19,15,16);
/*!40000 ALTER TABLE `libros_autores` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER evitarAutorDuplicado
BEFORE INSERT ON libros_autores
FOR EACH ROW
BEGIN 
  IF (NEW.idAutor IN (SELECT idAutor FROM libros_autores WHERE idLibro = NEW.idLibro))
  THEN 
   SIGNAL SQLSTATE '45005' SET MESSAGE_TEXT = 'EL AUTOR ESTABA PREVIAMENTE AGREGADO.';
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros_categorias`
--

LOCK TABLES `libros_categorias` WRITE;
/*!40000 ALTER TABLE `libros_categorias` DISABLE KEYS */;
INSERT INTO `libros_categorias` VALUES (1,1,4),(2,2,5),(3,4,6),(4,3,7),(6,6,5),(7,7,8),(9,7,1),(10,8,8),(11,9,10),(12,10,11),(13,11,9),(14,12,6),(15,13,9),(16,14,2),(17,15,4);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moras`
--

LOCK TABLES `moras` WRITE;
/*!40000 ALTER TABLE `moras` DISABLE KEYS */;
INSERT INTO `moras` VALUES (2,2,2.50,'PENDIENTE');
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
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'INICIAR SESION'),(2,'GESTIONAR AUTORES'),(3,'GESTIONAR CATEGORIAS'),(4,'GESTIONAR EDITORIALES'),(5,'GESTIONAR EMPLEADOS'),(6,'GESTIONAR LECTORES'),(7,'GESTIONAR USUARIOS EMPLEADOS'),(8,'GESTIONAR USUARIOS LECTORES'),(9,'GESTIONAR LIBROS'),(10,'GESTIONAR EJEMPLARES'),(11,'BUSCAR LIBROS'),(12,'GESTIONAR PRESTAMOS'),(13,'DETALLES DE PRESTAMOS'),(14,'MIS PRESTAMOS'),(15,'GESTIONAR DEVOLUCIONES'),(16,'GESTIONAR MORAS'),(17,'MIS MORAS'),(18,'GESTIONAR PAGOS'),(19,'HISTORIAL DE PAGOS'),(20,'INFORMES'),(21,'GESTIONAR ROLES'),(22,'GESTIONAR PERMISOS'),(23,'GESTIONAR OPCIONES'),(24,'CERRAR SESION');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,'DONACIÓN','2022-05-05 20:15:20',250.00,1,1),(2,'REPOSICIÓN DE CARNET','2022-05-06 01:32:10',10.00,1,3),(3,'DONACIÓN','2022-05-23 13:19:19',100.00,3,3);
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
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(4,1,3),(5,1,4),(7,1,6),(8,1,8),(9,1,9),(10,1,10),(11,1,11),(12,1,12),(13,1,13),(15,1,15),(16,1,16),(18,1,18),(20,2,1),(21,2,11),(22,2,14),(23,2,17),(24,2,19),(25,2,24),(26,1,24),(27,3,1),(28,3,2),(29,3,3),(30,3,4),(31,3,5),(32,3,6),(33,3,7),(34,3,8),(35,3,9),(36,3,10),(37,3,11),(38,3,12),(39,3,13),(41,3,15),(42,3,16),(44,3,18),(46,3,20),(47,3,21),(48,3,22),(49,3,23),(50,3,24),(51,4,1),(52,4,2),(53,4,3),(54,4,4),(55,4,9),(56,4,10),(57,4,11),(58,4,12),(59,4,13),(60,4,15),(61,4,16),(62,4,24);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos`
--

LOCK TABLES `prestamos` WRITE;
/*!40000 ALTER TABLE `prestamos` DISABLE KEYS */;
INSERT INTO `prestamos` VALUES (1,1,3,'2022-05-09 06:58:27'),(2,2,2,'2022-05-09 19:23:48'),(3,3,1,'2022-05-15 23:33:53'),(4,1,1,'2022-05-23 13:11:58');
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'ADMINISTRADOR'),(2,'LECTOR'),(3,'GERENTE'),(4,'PASANTE');
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
  `fecha_creacion` datetime NOT NULL,
  `idEmpleado` int(10) unsigned NOT NULL,
  `idRol` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  KEY `fk_Usuarios_Empleados_Empleados1_idx` (`idEmpleado`),
  KEY `fk_usuarios_empleados_roles1_idx` (`idRol`),
  CONSTRAINT `fk_Usuarios_Empleados_Empleados1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarios_empleados_roles1` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_empleados`
--

LOCK TABLES `usuarios_empleados` WRITE;
/*!40000 ALTER TABLE `usuarios_empleados` DISABLE KEYS */;
INSERT INTO `usuarios_empleados` VALUES (1,'diana24','jfoz3PSLiB3B1f9G+emL7w==','ACTIVO','2022-03-16 00:00:00',1,3),(2,'nestor11','Ec6fQdMglQbhFEy9TQztEw==','ACTIVO','2022-05-04 00:00:00',2,3),(3,'marili05','jfoz3PSLiB3B1f9G+emL7w==','ACTIVO','2022-05-05 18:51:03',3,1),(5,'prueba','jfoz3PSLiB3B1f9G+emL7w==','SUSPENDIDO','2022-05-06 00:24:09',4,4),(6,'gabs28','jfoz3PSLiB3B1f9G+emL7w==','ACTIVO','2022-05-06 00:24:09',5,3),(7,'sofia10','l7HI61M0z+9+90FQPSajOg==','ACTIVO','2022-05-23 13:02:18',4,1);
/*!40000 ALTER TABLE `usuarios_empleados` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER evitarUsuarioDuplicado1
BEFORE INSERT ON usuarios_empleados
FOR EACH ROW
BEGIN 
  IF (NEW.usuario IN (SELECT b.usuario FROM usuarios_lectores b))
  THEN 
   SIGNAL SQLSTATE '45010' SET MESSAGE_TEXT = 'ESE NOMBRE DE USUARIO YA SE ENCUENTRA REGISTRADO.';
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `usuarios_lectores`
--

DROP TABLE IF EXISTS `usuarios_lectores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios_lectores` (
  `idUsuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_lectores`
--

LOCK TABLES `usuarios_lectores` WRITE;
/*!40000 ALTER TABLE `usuarios_lectores` DISABLE KEYS */;
INSERT INTO `usuarios_lectores` VALUES (1,'gaby_28','Ec6fQdMglQbhFEy9TQztEw==','ACTIVO','VERDADERO','2022-04-03 12:00:00',1,2),(2,'manuGarcia','jfoz3PSLiB3B1f9G+emL7w==','ACTIVO','FALSO','2022-05-04 12:00:00',3,2),(3,'loremore','jfoz3PSLiB3B1f9G+emL7w==','ACTIVO','FALSO','2022-05-05 07:29:11',4,2),(5,'erick00','l7HI61M0z+9+90FQPSajOg==','ACTIVO','FALSO','2022-05-23 01:55:06',5,2);
/*!40000 ALTER TABLE `usuarios_lectores` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER evitarUsuarioDuplicado2
BEFORE INSERT ON usuarios_lectores
FOR EACH ROW
BEGIN 
  IF (NEW.usuario IN (SELECT b.usuario FROM usuarios_empleados b))
  THEN 
   SIGNAL SQLSTATE '45011' SET MESSAGE_TEXT = 'ESE NOMBRE DE USUARIO YA SE ENCUENTRA REGISTRADO.';
  END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-23 17:15:58
