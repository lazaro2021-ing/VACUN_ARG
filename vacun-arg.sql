-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: vacun-arg
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `center_vaccine`
--

DROP TABLE IF EXISTS `center_vaccine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `center_vaccine` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_vaccine` int NOT NULL,
  `id_center` int NOT NULL,
  `dosis` int NOT NULL,
  `aplicadas` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_vaccine_idx` (`id_vaccine`),
  KEY `id_center_idx` (`id_center`),
  CONSTRAINT `id_center` FOREIGN KEY (`id_center`) REFERENCES `centers` (`id`),
  CONSTRAINT `id_vaccine` FOREIGN KEY (`id_vaccine`) REFERENCES `vaccine` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `center_vaccine`
--

LOCK TABLES `center_vaccine` WRITE;
/*!40000 ALTER TABLE `center_vaccine` DISABLE KEYS */;
INSERT INTO `center_vaccine` VALUES (31,17,29,100,4),(34,18,29,100,2),(37,18,31,100,0),(38,19,29,100,3),(39,17,30,100,0),(40,21,30,100,0),(41,21,29,100,2),(42,17,33,1000,0),(43,20,33,1000,0),(44,22,34,100,0),(45,17,34,50,0),(46,22,29,50,1);
/*!40000 ALTER TABLE `center_vaccine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centers`
--

DROP TABLE IF EXISTS `centers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `centers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `departamento` varchar(100) NOT NULL,
  `localidad` varchar(45) NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `provincia` varchar(100) NOT NULL,
  `aplicadas` int DEFAULT NULL,
  `macAddress` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centers`
--

LOCK TABLES `centers` WRITE;
/*!40000 ALTER TABLE `centers` DISABLE KEYS */;
INSERT INTO `centers` VALUES (29,'CdelU','Uruguay','CONCEPCION DEL URUGUAY',NULL,'Entre Ríos',0,'9C29761DBC5D'),(30,'Concordia','Concordia','CONCORDIA',NULL,'Entre Ríos',0,''),(31,'Tigre','Tigre','TIGRE',NULL,'Buenos Aires',0,NULL),(32,'Viale','Paraná','VIALE',NULL,'Entre Ríos',0,NULL),(33,'Crespo','Paraná','CRESPO',NULL,'Entre Ríos',0,NULL),(34,'Centro Esperanza','Iguazú','ESPERANZA',NULL,'Misiones',0,'');
/*!40000 ALTER TABLE `centers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mac_centers`
--

DROP TABLE IF EXISTS `mac_centers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mac_centers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_center` int NOT NULL,
  `mac` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `mac_UNIQUE` (`mac`),
  KEY `fk_mac_idx` (`id_center`),
  CONSTRAINT `fk_mac` FOREIGN KEY (`id_center`) REFERENCES `centers` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mac_centers`
--

LOCK TABLES `mac_centers` WRITE;
/*!40000 ALTER TABLE `mac_centers` DISABLE KEYS */;
INSERT INTO `mac_centers` VALUES (1,29,'9C29761DBC5D');
/*!40000 ALTER TABLE `mac_centers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `people`
--

DROP TABLE IF EXISTS `people`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `people` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `dni_type` varchar(45) NOT NULL,
  `dni_numero` int NOT NULL,
  `nacionalidad` varchar(45) NOT NULL,
  `nacimiento` varchar(100) NOT NULL,
  `calle` varchar(100) NOT NULL,
  `numero` int NOT NULL,
  `cp` int NOT NULL,
  `provincia` varchar(100) NOT NULL,
  `departamento` varchar(100) NOT NULL,
  `localidad` varchar(100) NOT NULL,
  `tel_personal` varchar(100) NOT NULL,
  `tel_emergencias` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni_numero_UNIQUE` (`dni_numero`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `people`
--

LOCK TABLES `people` WRITE;
/*!40000 ALTER TABLE `people` DISABLE KEYS */;
INSERT INTO `people` VALUES (19,'Lazaro Deusich','DNI',33364451,'Argentina','lunes, 1 de noviembre de 2021','Lucilo Lopez',1522,3260,'Entre Ríos','Uruguay','CONCEPCION DEL URUGUAY','3442625672','3442625672','lazarodeusich@gmai.com'),(20,'Natalia Rapesta','DNI',35116842,'Antártida','miércoles, 3 de noviembre de 2021','Lucilo Lopez ',1522,3260,'Entre Ríos','Uruguay','CONCEPCION DEL URUGUAY','03442625672','03442625672','ndrapesta@gmail.com'),(21,'Victor','DNI',16127596,'Argentina','sábado, 11 de diciembre de 2021','Primo Paoloni',608,3218,'Entre Ríos','San Salvador','SAN SALVADOR','03451599926','03451599926','victorjuan@gmai.com');
/*!40000 ALTER TABLE `people` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `people_vaccine`
--

DROP TABLE IF EXISTS `people_vaccine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `people_vaccine` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_people` int NOT NULL,
  `id_vaccine` int NOT NULL,
  `id_center_p` int NOT NULL,
  `dosis` int NOT NULL,
  `fecha` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_people_fk_idx` (`id_people`),
  KEY `id_vaccine_fk_idx` (`id_vaccine`),
  KEY `id_center_fk_idx` (`id_center_p`),
  CONSTRAINT `id_center_p_fk` FOREIGN KEY (`id_center_p`) REFERENCES `centers` (`id`),
  CONSTRAINT `id_people_fk` FOREIGN KEY (`id_people`) REFERENCES `people` (`id`),
  CONSTRAINT `id_vaccine_fk` FOREIGN KEY (`id_vaccine`) REFERENCES `vaccine` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `people_vaccine`
--

LOCK TABLES `people_vaccine` WRITE;
/*!40000 ALTER TABLE `people_vaccine` DISABLE KEYS */;
INSERT INTO `people_vaccine` VALUES (40,19,17,29,1,'01-11-2021'),(41,19,18,29,2,'02-11-2021'),(42,19,19,29,3,'02-11-2021'),(43,19,19,29,4,'03-11-2021'),(44,19,21,29,5,'03-11-2021'),(45,20,17,29,1,'04-11-2021'),(46,19,17,29,6,'04-12-2021'),(47,19,18,29,7,'04-12-2021'),(48,20,21,29,2,'04-12-2021'),(49,21,17,29,1,'11-12-2021'),(50,21,19,29,2,'11-12-2021'),(51,21,22,29,3,'11-12-2021');
/*!40000 ALTER TABLE `people_vaccine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vaccine`
--

DROP TABLE IF EXISTS `vaccine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vaccine` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `dosis` int NOT NULL,
  `disponibles` int DEFAULT NULL,
  `aplicadas` int DEFAULT NULL,
  `pais` varchar(100) NOT NULL,
  `temp` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vaccine`
--

LOCK TABLES `vaccine` WRITE;
/*!40000 ALTER TABLE `vaccine` DISABLE KEYS */;
INSERT INTO `vaccine` VALUES (17,'Moderna',1505,251,4,'EEUU',0),(18,'SputnikV',1000,798,2,'Rusia',0),(19,'AstraZeneca',1000,897,3,'ReinoUnido',0),(20,'Pfizer',1000,0,0,'EEUU',0),(21,'Sinopharm',1000,798,2,'China',0),(22,'CanSino',2000,1849,1,'China',1);
/*!40000 ALTER TABLE `vaccine` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-12 20:36:16
