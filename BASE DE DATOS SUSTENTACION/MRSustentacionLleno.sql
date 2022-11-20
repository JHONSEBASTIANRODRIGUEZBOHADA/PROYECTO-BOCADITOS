-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: bocaditos_bd
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `detallesmateriaprima`
--

DROP TABLE IF EXISTS `detallesmateriaprima`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallesmateriaprima` (
  `detmId` int NOT NULL AUTO_INCREMENT,
  `proId_fk` int NOT NULL,
  `matId_fk` int NOT NULL,
  `detmCantidad` int NOT NULL,
  PRIMARY KEY (`detmId`),
  KEY `proId_fk_idx` (`proId_fk`),
  KEY `matId_fk_idx` (`matId_fk`),
  CONSTRAINT `matId_fk` FOREIGN KEY (`matId_fk`) REFERENCES `materiaprima` (`matId`),
  CONSTRAINT `proId_fk` FOREIGN KEY (`proId_fk`) REFERENCES `producto` (`proId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallesmateriaprima`
--

LOCK TABLES `detallesmateriaprima` WRITE;
/*!40000 ALTER TABLE `detallesmateriaprima` DISABLE KEYS */;
INSERT INTO `detallesmateriaprima` VALUES (5,2,1,100),(6,2,2,1),(7,4,1,50),(8,4,2,1);
/*!40000 ALTER TABLE `detallesmateriaprima` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallesorden`
--

DROP TABLE IF EXISTS `detallesorden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallesorden` (
  `detoId` int NOT NULL AUTO_INCREMENT,
  `ordId_fk` int NOT NULL,
  `prodId_fk` int NOT NULL,
  `detoCantidad` int NOT NULL,
  `detoDetalles` varchar(50) DEFAULT NULL,
  `detoPrecio` double NOT NULL,
  `detoDescuento` double DEFAULT NULL,
  PRIMARY KEY (`detoId`),
  KEY `ordId_fk_idx` (`ordId_fk`),
  KEY `prodId_fk_idx` (`prodId_fk`),
  CONSTRAINT `ordId_fk` FOREIGN KEY (`ordId_fk`) REFERENCES `orden` (`ordId`),
  CONSTRAINT `prodId_fk` FOREIGN KEY (`prodId_fk`) REFERENCES `producto` (`proId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallesorden`
--

LOCK TABLES `detallesorden` WRITE;
/*!40000 ALTER TABLE `detallesorden` DISABLE KEYS */;
INSERT INTO `detallesorden` VALUES (1,1,2,10,'Decorados de mickey',7000,NULL);
/*!40000 ALTER TABLE `detallesorden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallespedido`
--

DROP TABLE IF EXISTS `detallespedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallespedido` (
  `detpId` int NOT NULL AUTO_INCREMENT,
  `pedId_fk` int NOT NULL,
  `matpId_fk` int NOT NULL,
  `detpPrecioUnidad` double DEFAULT NULL,
  `detpCantidad` int DEFAULT NULL,
  PRIMARY KEY (`detpId`),
  KEY `fk_detallespedido_pedido1_idx` (`pedId_fk`),
  KEY `matpId_fk_idx` (`matpId_fk`),
  CONSTRAINT `fk_detallespedido_pedido1` FOREIGN KEY (`pedId_fk`) REFERENCES `pedido` (`pedId`),
  CONSTRAINT `matpId_fk` FOREIGN KEY (`matpId_fk`) REFERENCES `materiaprima` (`matId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallespedido`
--

LOCK TABLES `detallespedido` WRITE;
/*!40000 ALTER TABLE `detallespedido` DISABLE KEYS */;
INSERT INTO `detallespedido` VALUES (1,1,1,3000,10),(2,1,2,600,30);
/*!40000 ALTER TABLE `detallespedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiaprima`
--

DROP TABLE IF EXISTS `materiaprima`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiaprima` (
  `matId` int NOT NULL AUTO_INCREMENT,
  `matNombre` varchar(50) NOT NULL,
  `matCantidad` int NOT NULL,
  `matEstado` varchar(45) NOT NULL,
  `matPrecioUnidad` double NOT NULL,
  PRIMARY KEY (`matId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiaprima`
--

LOCK TABLES `materiaprima` WRITE;
/*!40000 ALTER TABLE `materiaprima` DISABLE KEYS */;
INSERT INTO `materiaprima` VALUES (1,'Azucar',10,'Activo',3000),(2,'Huevo',30,'Activo',600);
/*!40000 ALTER TABLE `materiaprima` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden`
--

DROP TABLE IF EXISTS `orden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orden` (
  `ordId` int NOT NULL AUTO_INCREMENT,
  `ordFechaEntrega` date DEFAULT NULL,
  `ordFechaPedido` date NOT NULL,
  `ordEstado` varchar(45) NOT NULL,
  `ordIdCliente` int NOT NULL,
  `ordIdRepostero` int DEFAULT NULL,
  `ordIdDomiciliario` int DEFAULT NULL,
  PRIMARY KEY (`ordId`),
  KEY `fk_orden_usuario1_idx` (`ordIdCliente`),
  CONSTRAINT `fk_orden_usuario1` FOREIGN KEY (`ordIdCliente`) REFERENCES `usuario` (`usuId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden`
--

LOCK TABLES `orden` WRITE;
/*!40000 ALTER TABLE `orden` DISABLE KEYS */;
INSERT INTO `orden` VALUES (1,'2022-05-12','2022-05-10','Entregada',5,7,6),(3,'2022-09-25','2022-09-20','Entregada',4,7,6),(4,NULL,'2022-11-19','Aprobada',5,NULL,NULL);
/*!40000 ALTER TABLE `orden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `pedId` int NOT NULL AUTO_INCREMENT,
  `pedFechaPedido` date NOT NULL,
  `pedFechaEntrega` date DEFAULT NULL,
  `pedEstado` varchar(45) NOT NULL,
  `prvId_fk` int NOT NULL,
  PRIMARY KEY (`pedId`),
  KEY `fk_pedido_proveedor1_idx` (`prvId_fk`),
  CONSTRAINT `fk_pedido_proveedor1` FOREIGN KEY (`prvId_fk`) REFERENCES `proveedor` (`prvId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,'2022-10-30','2022-11-02','Entregado',1),(2,'2022-11-19',NULL,'Pedido',1);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `proId` int NOT NULL AUTO_INCREMENT,
  `proNombre` varchar(50) NOT NULL,
  `proCantidad` int NOT NULL,
  `proEstado` varchar(45) NOT NULL,
  `proPrecio` double NOT NULL,
  PRIMARY KEY (`proId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (2,'Cupcake',10,'Activo',5000),(4,'Galleta',50,'Activo',3000),(5,'Torta',2,'Activo',40000);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `prvId` int NOT NULL AUTO_INCREMENT,
  `prvNit` int NOT NULL,
  `prvNombre` varchar(50) NOT NULL,
  `prvDireccion` varchar(100) NOT NULL,
  `prvTelefono` bigint DEFAULT NULL,
  `prvCorreo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`prvId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,100,'Makro','Autopista sur',32020202,'makro@gmail.com');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `rolId` int NOT NULL AUTO_INCREMENT,
  `rolDescripcion` varchar(25) NOT NULL,
  PRIMARY KEY (`rolId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Cliente'),(3,'Repostero'),(4,'Domiciliario');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `usuId` int NOT NULL AUTO_INCREMENT,
  `usuCorreo` varchar(50) NOT NULL,
  `usuContraseña` varchar(16) NOT NULL,
  `usuApellido` varchar(45) NOT NULL,
  `usuNombre` varchar(45) NOT NULL,
  `usuDocumento` int NOT NULL,
  `usuTelefono` bigint NOT NULL,
  `usuDireccion` varchar(70) NOT NULL,
  `usuEstado` varchar(45) NOT NULL,
  `rolId_fk` int NOT NULL,
  PRIMARY KEY (`usuId`),
  UNIQUE KEY `usuCorreo_UNIQUE` (`usuCorreo`),
  KEY `rolId_idx` (`rolId_fk`) /*!80000 INVISIBLE */,
  CONSTRAINT `rolId_fk` FOREIGN KEY (`rolId_fk`) REFERENCES `roles` (`rolId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'bocaditos@gmail.com','123','Ramirez','Leandro',1032000030,3192557948,'Calle 59 sur','Activo',1),(3,'luis727@gmail.com','17282828LP','Parra','Luis',1030292938,3205776849,'Diagonal 48 Sur','Activo',2),(4,'cesarperez@gmail.com','cesar99hd','Perez','Cesar',1029039930,3159494948,'Av. Caracas 33','Activo',2),(5,'karentat@gmail.com','katat8338','Contreras','Karen',1003293933,3200848484,'El paraiso calle 12','Activo',2),(6,'paulalvarez12@gmail.com','alvpau33223','Alvarez','Paul',1020393944,3169988473,'Calle 40 Sur','Activo',4),(7,'vanessa17@gmail.com','vane1797','Ramirez','Vanessa',1003832933,3209494994,'Calle 80','Activo',3);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-19 22:06:05
