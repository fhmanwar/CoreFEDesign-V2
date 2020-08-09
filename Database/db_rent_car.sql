-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               5.7.24 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for db_rent_car
CREATE DATABASE IF NOT EXISTS `db_rent_car` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_rent_car`;

-- Dumping structure for procedure db_rent_car.CarSPDelete
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPDelete`(in id int)
BEGIN
	delete from Tbl_Car where id_car = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.CarSPEdit
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPEdit`(
	in id int, 
	in name varchar(50),
	in transmition varchar(50),
	in year int,
	in price int,
	in merkID int
)
BEGIN
	Update Tbl_Car
	set 
		nm_car = name,
		transmition = transmition,
		year = year,
		price = price,
		merk_id = merkID
	where id_car = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.CarSPGetAll
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPGetAll`()
BEGIN
	SELECT 
		Car.id_car,
		Car.nm_car,
		Car.transmition,
		Car.year,
		Car.price,
		Merk.id_merk as merkID,
		Merk.merk as merkName
	from Tbl_Car Car
	JOIN Tbl_Merk Merk ON Car.merk_id = Merk.id_merk;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.CarSPGetID
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPGetID`(in id int)
BEGIN
	SELECT 
		Car.id_car,
		Car.nm_car,
		Car.transmition,
		Car.year,
		Car.price,
		Merk.id_merk as merkID,
		Merk.merk as merkName
	from Tbl_Car Car
	JOIN Tbl_Merk Merk ON Car.merk_id = Merk.id_merk
	where Car.id_car = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.CarSPInsert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPInsert`(
	in Name varchar(50),
	in transmition varchar(50),
	in year int,
	in price int,
	in merkID int
)
BEGIN
	INSERT INTO Tbl_Car(nm_car,transmition,year,price,merk_id) 
		values (Name,transmition,year,price,merkID);
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ChartSPLine
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ChartSPLine`()
BEGIN
	SELECT 
		Reserve.start_date "date",
		DATEDIFF(Reserve.end_date,Reserve.start_date) as days,
		Car.nm_car as car
	from Tbl_Reserve Reserve
    JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN tbl_car Car ON Reserve.car_id = Car.id_car
	JOIN tbl_merk Merk ON Car.merk_id = Merk.id_merk;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ChartSPPie
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ChartSPPie`()
BEGIN
	SELECT 
		Car.nm_car as car,
		COUNT(Reserve.id_reserve) as total
	from tbl_reserve Reserve
	JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN tbl_car Car ON Reserve.car_id = Car.id_car
	JOIN tbl_merk Merk ON Car.merk_id = Merk.id_merk
	Group BY Car.nm_car;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.MerkSPDelete
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPDelete`(in id int)
BEGIN
	delete from Tbl_Merk where id_merk = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.MerkSPEdit
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPEdit`(in id int, in merk varchar(50))
BEGIN
	Update Tbl_Merk
	set merk = merk
	where id_merk = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.MerkSPGetAll
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPGetAll`()
BEGIN
	SELECT * 
	from Tbl_Merk;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.MerkSPGetID
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPGetID`(in id int)
BEGIN
	SELECT * 
	from Tbl_Merk 
	where id_merk = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.MerkSPInsert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPInsert`(
	in merk varchar(50)
)
BEGIN
	insert into Tbl_Merk(merk) values (merk);
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ReserveSPDelete
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPDelete`(in id int)
BEGIN
	delete from Tbl_Reserve where id_reserve = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ReserveSPEdit
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPEdit`(
	in id int,
	in start Date,
	in end Date,
	in status varchar(20),
	in tot int,
	in tgl_bayar Date,
	in carID int,
	in konsumenID int
)
BEGIN
	Update Tbl_Reserve
	set
		start_date = start,
		end_date = end,
		status = status,
		total = tot,
		tgl_bayar = tgl_bayar,
		car_id = carID,
		account_id = accountID
	where id_reserve = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ReserveSPGetAll
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPGetAll`()
BEGIN
	SELECT 
		Reserve.id_reserve,
		Reserve.start_date,
		Reserve.end_date,
		Reserve.status,
		Reserve.total,
		Reserve.tgl_bayar,
		Car.id_car as carID,
		Car.nm_car as carName,
		Car.transmition as carTransmition,
		Car.year as carYear,
		Merk.merk as carMerk,
		a.id_account as accountID,
		a.nama as accountName,
		a.alamat as accountAlamat,
		a.tlp as accountPhone
	from Tbl_Reserve Reserve
    JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN Tbl_Car Car ON Reserve.car_id = Car.id_car
	JOIN Tbl_Merk Merk ON Car.merk_id = Merk.id_merk;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ReserveSPGetID
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPGetID`(in id int)
BEGIN
	SELECT 
		Reserve.id_reserve,
		Reserve.start_date,
		Reserve.end_date,
		Reserve.status,
		Reserve.total,
		Reserve.tgl_bayar,
		Car.id_car as carID,
		Car.nm_car as carName,
		Car.transmition as carTransmition,
		Car.year as carYear,
		Merk.merk as carMerk,
		a.id_account as accountID,
		a.nama as accountName,
		a.alamat as accountAlamat,
		a.tlp as accountPhone
	from Tbl_Reserve Reserve
	JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN Tbl_Car Car ON Reserve.car_id = Car.id_car
	JOIN Tbl_Merk Merk ON Car.merk_id = Merk.id_merk
	where Reserve.id_reserve = id;
END//
DELIMITER ;

-- Dumping structure for procedure db_rent_car.ReserveSPInsert
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPInsert`(
	in start Date,
	in end Date,
	in status varchar(20),
	in tot int,
	in tgl_bayar Date,
	in carID int,
	in konsumenID int
)
BEGIN
	INSERT INTO Tbl_Reserve
		values (start,end,status,tot,tgl_bayar,car_id,konsumen_id);
END//
DELIMITER ;

-- Dumping structure for table db_rent_car.tbl_account
CREATE TABLE IF NOT EXISTS `tbl_account` (
  `id_account` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `access_level` varchar(15) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_account`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table db_rent_car.tbl_account: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_account` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_account` ENABLE KEYS */;

-- Dumping structure for table db_rent_car.tbl_car
CREATE TABLE IF NOT EXISTS `tbl_car` (
  `id_car` int(11) NOT NULL AUTO_INCREMENT,
  `nm_car` int(11) DEFAULT NULL,
  `transmition` varchar(50) DEFAULT NULL,
  `year` year(4) DEFAULT NULL,
  `merk_id` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_car`),
  KEY `idx_tbl_car_merk_id` (`merk_id`) COMMENT 'Foreign Key',
  KEY `FK_Merk` (`merk_id`),
  KEY `FK_Account` (`account_id`),
  CONSTRAINT `FK_tbl_car_tbl_account` FOREIGN KEY (`account_id`) REFERENCES `tbl_account` (`id_account`),
  CONSTRAINT `FK_tbl_car_tbl_merk` FOREIGN KEY (`merk_id`) REFERENCES `tbl_merk` (`id_merk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table db_rent_car.tbl_car: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_car` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_car` ENABLE KEYS */;

-- Dumping structure for table db_rent_car.tbl_merk
CREATE TABLE IF NOT EXISTS `tbl_merk` (
  `id_merk` int(11) NOT NULL AUTO_INCREMENT,
  `merk` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_merk`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table db_rent_car.tbl_merk: ~2 rows (approximately)
/*!40000 ALTER TABLE `tbl_merk` DISABLE KEYS */;
INSERT INTO `tbl_merk` (`id_merk`, `merk`) VALUES
	(1, 'Toyota'),
	(2, 'Honda');
/*!40000 ALTER TABLE `tbl_merk` ENABLE KEYS */;

-- Dumping structure for table db_rent_car.tbl_reserve
CREATE TABLE IF NOT EXISTS `tbl_reserve` (
  `id_reserve` int(11) NOT NULL AUTO_INCREMENT,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `tgl_bayar` date DEFAULT NULL,
  `car_id` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_reserve`),
  KEY `FK_Car` (`car_id`),
  KEY `FK_Account` (`account_id`),
  CONSTRAINT `FK_tbl_reserve_tbl_account` FOREIGN KEY (`account_id`) REFERENCES `tbl_account` (`id_account`),
  CONSTRAINT `FK_tbl_reserve_tbl_car` FOREIGN KEY (`car_id`) REFERENCES `tbl_car` (`id_car`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table db_rent_car.tbl_reserve: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbl_reserve` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reserve` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
