-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.37-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bbdd_placemybet
CREATE DATABASE IF NOT EXISTS `bbdd_placemybet` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bbdd_placemybet`;

-- Volcando estructura para tabla bbdd_placemybet.apuesta
CREATE TABLE IF NOT EXISTS `apuesta` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cuota` double NOT NULL DEFAULT '0',
  `Tipo_Apuesta` varchar(50) NOT NULL DEFAULT '0',
  `Dinero_Apostado` int(11) NOT NULL DEFAULT '0',
  `Fecha` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bbdd_placemybet.apuesta: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `apuesta` DISABLE KEYS */;
INSERT INTO `apuesta` (`ID`, `Cuota`, `Tipo_Apuesta`, `Dinero_Apostado`, `Fecha`) VALUES
	(1, 2.85, 'under', 30, '2020-09-18');
/*!40000 ALTER TABLE `apuesta` ENABLE KEYS */;

-- Volcando estructura para tabla bbdd_placemybet.cuenta_banco
CREATE TABLE IF NOT EXISTS `cuenta_banco` (
  `Tarjeta_Credito` int(11) DEFAULT NULL,
  `Nombre_Banco` varchar(50) DEFAULT NULL,
  `Saldo_Actual` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bbdd_placemybet.cuenta_banco: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `cuenta_banco` DISABLE KEYS */;
INSERT INTO `cuenta_banco` (`Tarjeta_Credito`, `Nombre_Banco`, `Saldo_Actual`) VALUES
	(1929929192, 'Kenny Bell', 912);
/*!40000 ALTER TABLE `cuenta_banco` ENABLE KEYS */;

-- Volcando estructura para tabla bbdd_placemybet.evento
CREATE TABLE IF NOT EXISTS `evento` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Equipo_Local` varchar(50) DEFAULT NULL,
  `Equipo_Visitante` varchar(50) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Goles` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bbdd_placemybet.evento: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` (`ID`, `Equipo_Local`, `Equipo_Visitante`, `Fecha`, `Goles`) VALUES
	(1, 'Valencia CF', 'Espanyol', '2020-09-18', 2);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;

-- Volcando estructura para tabla bbdd_placemybet.mercado
CREATE TABLE IF NOT EXISTS `mercado` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OverUnder` double NOT NULL DEFAULT '0',
  `Cuota_Over` double NOT NULL DEFAULT '0',
  `Cuota_Under` double NOT NULL DEFAULT '0',
  `Dinero_Over` double NOT NULL DEFAULT '0',
  `Dinero_Under` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bbdd_placemybet.mercado: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `mercado` DISABLE KEYS */;
INSERT INTO `mercado` (`ID`, `OverUnder`, `Cuota_Over`, `Cuota_Under`, `Dinero_Over`, `Dinero_Under`) VALUES
	(1, 1.5, 1.43, 2.85, 100, 50),
	(2, 2.5, 1.9, 1.9, 100, 100),
	(3, 3.5, 2.85, 1.43, 50, 100);
/*!40000 ALTER TABLE `mercado` ENABLE KEYS */;

-- Volcando estructura para tabla bbdd_placemybet.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `Email` varchar(50) NOT NULL,
  `Nombre` char(50) DEFAULT NULL,
  `Apellido` char(50) DEFAULT NULL,
  `Edad` char(50) DEFAULT NULL,
  PRIMARY KEY (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla bbdd_placemybet.usuario: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`Email`, `Nombre`, `Apellido`, `Edad`) VALUES
	('pepito@gmail.com', 'Pepito', 'De los Palotes', '19');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
