-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ferreteria
-- ------------------------------------------------------
-- Server version	8.0.24

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
-- Table structure for table `cantidadxproducto`
--

DROP TABLE IF EXISTS `cantidadxproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cantidadxproducto` (
  `ID_producto` int NOT NULL,
  `ID_Categorias` int NOT NULL,
  `ID_Venta` int NOT NULL,
  `Cantidad` int NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`ID_producto`,`ID_Categorias`,`ID_Venta`),
  KEY `fk_Productos_has_Venta_Venta_idx` (`ID_Venta`),
  KEY `fk_Productos_has_Venta_Productos_idx` (`ID_producto`,`ID_Categorias`),
  CONSTRAINT `fk_Productos_has_Venta_Productos` FOREIGN KEY (`ID_producto`, `ID_Categorias`) REFERENCES `productos` (`ID_producto`, `ID_Categorias`),
  CONSTRAINT `fk_Productos_has_Venta_Venta` FOREIGN KEY (`ID_Venta`) REFERENCES `venta` (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cantidadxproducto`
--

LOCK TABLES `cantidadxproducto` WRITE;
/*!40000 ALTER TABLE `cantidadxproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `cantidadxproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cantidadxsobrepedido`
--

DROP TABLE IF EXISTS `cantidadxsobrepedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cantidadxsobrepedido` (
  `Sobrepedido_ID_SobrePedido` int NOT NULL,
  KEY `fk_CantidadXsobrepedido_Sobrepedido_idx` (`Sobrepedido_ID_SobrePedido`),
  CONSTRAINT `fk_CantidadXsobrepedido_Sobrepedido` FOREIGN KEY (`Sobrepedido_ID_SobrePedido`) REFERENCES `sobrepedido` (`ID_SobrePedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cantidadxsobrepedido`
--

LOCK TABLES `cantidadxsobrepedido` WRITE;
/*!40000 ALTER TABLE `cantidadxsobrepedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `cantidadxsobrepedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `ID_Categorias` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Categorias`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Herramientas'),(2,'Material electrico'),(3,'Material para plomeria'),(4,'Hogar'),(5,'Jardin'),(6,'Proteccion');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `ID_producto` int NOT NULL AUTO_INCREMENT,
  `ID_Categorias` int NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `Precio` double NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `InVentario` int NOT NULL,
  PRIMARY KEY (`ID_producto`,`ID_Categorias`),
  KEY `fk_Productos_Categorias1_idx` (`ID_Categorias`),
  CONSTRAINT `fk_Productos_Categorias1` FOREIGN KEY (`ID_Categorias`) REFERENCES `categorias` (`ID_Categorias`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,2,'Clavija','Voltek',10,'Clavija plastica, negra, Voltek',10),(2,3,'Tubo CPVC','Flowguard',110,'Tubo CPVC 1/2\", azul, Flowguard',25),(3,4,'Pilas AA','Voltek',12,'Pila alcalina AA, Voltek',20),(4,1,'Martillo','Pretul',95,'Martillo, 2 libras, mango de madera, Pretul.',3),(5,2,'Extencion electrica','Igoto',24,'Extencion electrica de 2m, Igoto, economica.',5),(6,6,'Lentes','Pretul',30,'Lentes de seguridad, transparentes, Pretul.',10);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provedor`
--

DROP TABLE IF EXISTS `provedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provedor` (
  `ID_Provedor` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Productos_ID_producto` int NOT NULL,
  `Productos_ID_Categorias` int NOT NULL,
  PRIMARY KEY (`ID_Provedor`),
  KEY `fk_Provedor_Productos_idx` (`Productos_ID_producto`,`Productos_ID_Categorias`),
  CONSTRAINT `fk_Provedor_Productos` FOREIGN KEY (`Productos_ID_producto`, `Productos_ID_Categorias`) REFERENCES `productos` (`ID_producto`, `ID_Categorias`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provedor`
--

LOCK TABLES `provedor` WRITE;
/*!40000 ALTER TABLE `provedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `provedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provee`
--

DROP TABLE IF EXISTS `provee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provee` (
  `nombre` varchar(40) DEFAULT NULL,
  `tel` varchar(40) DEFAULT NULL,
  `mail` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provee`
--

LOCK TABLES `provee` WRITE;
/*!40000 ALTER TABLE `provee` DISABLE KEYS */;
/*!40000 ALTER TABLE `provee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sobrepedido`
--

DROP TABLE IF EXISTS `sobrepedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sobrepedido` (
  `ID_SobrePedido` int NOT NULL AUTO_INCREMENT,
  `Anticipo` double NOT NULL,
  `Total` double NOT NULL,
  `Fecha_Inicio` date NOT NULL,
  `Fecha_Fin` date NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido_paterno` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_SobrePedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sobrepedido`
--

LOCK TABLES `sobrepedido` WRITE;
/*!40000 ALTER TABLE `sobrepedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `sobrepedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `ID_USER` int NOT NULL AUTO_INCREMENT,
  `USER` char(45) NOT NULL,
  `PASSWORD` char(45) NOT NULL,
  PRIMARY KEY (`ID_USER`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'ADMIN','PASSWORD');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `ID_Venta` int NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Total` double NOT NULL,
  PRIMARY KEY (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-06 23:11:06
