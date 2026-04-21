-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for db_sepatu
CREATE DATABASE IF NOT EXISTS `db_sepatu` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_sepatu`;

-- Dumping structure for table db_sepatu.tb_kategori
CREATE TABLE IF NOT EXISTS `tb_kategori` (
  `id_kategori` int NOT NULL AUTO_INCREMENT,
  `nama_kategori` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_kategori`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_sepatu.tb_kategori: ~3 rows (approximately)
INSERT INTO `tb_kategori` (`id_kategori`, `nama_kategori`) VALUES
	(1, 'Easy Run'),
	(2, 'Long Run'),
	(3, 'Sprint');

-- Dumping structure for table db_sepatu.tb_sepatu
CREATE TABLE IF NOT EXISTS `tb_sepatu` (
  `id_sepatu` int NOT NULL AUTO_INCREMENT,
  `merk` varchar(50) DEFAULT NULL,
  `Ukuran` int DEFAULT NULL,
  `Stok` int DEFAULT NULL,
  `id_kategori` int NOT NULL,
  PRIMARY KEY (`id_sepatu`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_sepatu.tb_sepatu: ~3 rows (approximately)
INSERT INTO `tb_sepatu` (`id_sepatu`, `merk`, `Ukuran`, `Stok`, `id_kategori`) VALUES
	(1, 'Adidas', 34, 5, 0),
	(2, 'Nike', 22, 6, 0),
	(3, 'Ortus', 44, 5, 2);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
