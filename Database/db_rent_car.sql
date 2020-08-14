-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Aug 14, 2020 at 12:30 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_rent_car`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountSPDelete` (IN `id` INT)  BEGIN
	delete 
    from tbl_account 
    where id_account = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountSPEdit` (IN `id` INT, IN `name` VARCHAR(100), IN `Uname` VARCHAR(50), IN `mail` VARCHAR(50), IN `pass` VARCHAR(255), IN `access` ENUM('Admin','User'), IN `addr` VARCHAR(100), IN `phone` VARCHAR(100))  BEGIN
	Update tbl_account
	set 
		name = name,
        username = Uname,
        email = mail,
        password = pass,
        access_level = access,
        address = addr,
        phone = phone
	where id_account = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountSPGetAll` ()  BEGIN
	select 
		id_account "id_acc",
        name "name",
        username "uname",
        email "mail",
        password "pass",
        access_level "access",
        address "addr",
        phone "phone"
    from tbl_account;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountSPGetID` (IN `id` INT)  BEGIN
	select 
		id_account "id_acc",
        name "name",
        username "uname",
        email "mail",
        password "pass",
        access_level "access",
        address "addr",
        phone "phone"
    from tbl_account
    where id_account = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AccountSPInsert` (IN `name` VARCHAR(100), IN `Uname` VARCHAR(50), IN `mail` VARCHAR(50), IN `pass` VARCHAR(255), IN `access` ENUM('Admin','User'), IN `addr` VARCHAR(100), IN `phone` VARCHAR(100))  BEGIN
	insert into tbl_account (name,username,email,password,access_level,address,phone)
    values (name,Uname,mail,pass,access,addr,phone);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AuthSPLogin` (IN `uname` VARCHAR(150))  BEGIN
	select 
		id_account "id_acc",
        name "name",
        username "uname",
        email "mail",
        password "pass",
        access_level "access",
        address "addr",
        phone "phone"
    from tbl_account
    where username = uname;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AuthSPRegis` (IN `name` VARCHAR(100), IN `Uname` VARCHAR(50), IN `mail` VARCHAR(50), IN `pass` VARCHAR(255))  BEGIN
	insert into tbl_account (name,username,email,password,access_level)
    values (name,Uname,mail,pass,"User");
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPDelete` (IN `id` INT)  BEGIN
	delete from Tbl_Car where id_car = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPEdit` (IN `id` INT, IN `name` VARCHAR(50), IN `transmition` VARCHAR(50), IN `year` INT, IN `price` INT, IN `merkID` INT)  BEGIN
	Update Tbl_Car
	set 
		nm_car = name,
		transmition = transmition,
		year = year,
		price = price,
		merk_id = merkID
	where id_car = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPGetAll` ()  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPGetID` (IN `id` INT)  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CarSPInsert` (IN `Name` VARCHAR(50), IN `transmition` VARCHAR(50), IN `year` INT, IN `price` INT, IN `merkID` INT)  BEGIN
	INSERT INTO Tbl_Car(nm_car,transmition,year,price,merk_id) 
		values (Name,transmition,year,price,merkID);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ChartSPLine` ()  BEGIN
	SELECT 
		Reserve.start_date "date",
		DATEDIFF(Reserve.end_date,Reserve.start_date) as days,
		Car.nm_car as car
	from Tbl_Reserve Reserve
    JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN tbl_car Car ON Reserve.car_id = Car.id_car
	JOIN tbl_merk Merk ON Car.merk_id = Merk.id_merk;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ChartSPPie` ()  BEGIN
	SELECT 
		Car.nm_car as car,
		COUNT(Reserve.id_reserve) as total
	from tbl_reserve Reserve
	JOIN Tbl_Account a ON Reserve.account_id = a.id_account
	JOIN tbl_car Car ON Reserve.car_id = Car.id_car
	JOIN tbl_merk Merk ON Car.merk_id = Merk.id_merk
	Group BY Car.nm_car;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPDelete` (IN `id` INT)  BEGIN
	delete from Tbl_Merk where id_merk = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPEdit` (IN `id` INT, IN `merk` VARCHAR(50))  BEGIN
	Update Tbl_Merk
	set merk = merk
	where id_merk = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPGetAll` ()  BEGIN
	SELECT * 
	from Tbl_Merk;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPGetID` (IN `id` INT)  BEGIN
	SELECT * 
	from Tbl_Merk 
	where id_merk = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `MerkSPInsert` (IN `merk` VARCHAR(50))  BEGIN
	insert into Tbl_Merk(merk) values (merk);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPDelete` (IN `id` INT)  BEGIN
	delete from Tbl_Reserve where id_reserve = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPEdit` (IN `id` INT, IN `start` DATE, IN `end` DATE, IN `status` VARCHAR(20), IN `tot` INT, IN `tgl_bayar` DATE, IN `carID` INT, IN `konsumenID` INT)  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPGetAll` ()  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPGetID` (IN `id` INT)  BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSPInsert` (IN `start` DATE, IN `end` DATE, IN `status` VARCHAR(20), IN `tot` INT, IN `tgl_bayar` DATE, IN `carID` INT, IN `konsumenID` INT)  BEGIN
	INSERT INTO Tbl_Reserve
		values (start,end,status,tot,tgl_bayar,car_id,konsumen_id);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE `tbl_account` (
  `id_account` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `access_level` enum('Admin','User') DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`id_account`, `name`, `username`, `email`, `password`, `access_level`, `address`, `phone`) VALUES
(6, 'Admin', 'admin', 'admin@admin.com', '$2a$11$/ccUUMzceyNm1lupDJssf.6YtU.nDI4w6kyv1lrMi9gypNet5G17m', 'Admin', 'Jakarta', '08123456789'),
(7, 'User', 'user', 'user@user.com', '$2a$11$/sXDsDLsT0af.frRymshA.aMCdvFmI23nywPVfA8xFkcT.NtsSFKK', 'User', 'Bekasi', '08123456789'),
(8, 'jon', 'jon123', 'jon@jon.net', '$2a$11$KEW3uL4b..w8JzENR38iueElt89PzGZnt.Bs7OXwOXm6iYQ125M0O', 'User', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_car`
--

CREATE TABLE `tbl_car` (
  `id_car` int(11) NOT NULL,
  `nm_car` varchar(100) DEFAULT NULL,
  `transmition` varchar(50) DEFAULT NULL,
  `year` year(4) DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `merk_id` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_car`
--

INSERT INTO `tbl_car` (`id_car`, `nm_car`, `transmition`, `year`, `price`, `merk_id`, `account_id`) VALUES
(1, 'Ayla', 'Automatic', 2019, 200000, 1, NULL),
(3, 'BRV', 'Automatic', 2018, 300000, 2, NULL),
(4, 'CR-V', 'Automatic', 2020, 500000, 2, NULL),
(5, 'E46', 'Automatic', 2002, 600000, 5, NULL),
(6, 'Golf GTI', 'Automatic', 2020, 1000000, 6, NULL),
(7, 'Scirocco', 'Automatic', 2020, 900000, 6, NULL),
(8, 'E90', 'Automatic', 2005, 950000, 5, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_merk`
--

CREATE TABLE `tbl_merk` (
  `id_merk` int(11) NOT NULL,
  `merk` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_merk`
--

INSERT INTO `tbl_merk` (`id_merk`, `merk`) VALUES
(1, 'Toyota'),
(2, 'Honda'),
(4, 'Suzuki'),
(5, 'BMW'),
(6, 'Volkswagen');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reserve`
--

CREATE TABLE `tbl_reserve` (
  `id_reserve` int(11) NOT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `tgl_bayar` date DEFAULT NULL,
  `car_id` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_account`
--
ALTER TABLE `tbl_account`
  ADD PRIMARY KEY (`id_account`);

--
-- Indexes for table `tbl_car`
--
ALTER TABLE `tbl_car`
  ADD PRIMARY KEY (`id_car`),
  ADD KEY `idx_tbl_car_merk_id` (`merk_id`) COMMENT 'Foreign Key',
  ADD KEY `FK_Merk` (`merk_id`),
  ADD KEY `FK_Account` (`account_id`);

--
-- Indexes for table `tbl_merk`
--
ALTER TABLE `tbl_merk`
  ADD PRIMARY KEY (`id_merk`);

--
-- Indexes for table `tbl_reserve`
--
ALTER TABLE `tbl_reserve`
  ADD PRIMARY KEY (`id_reserve`),
  ADD KEY `FK_Car` (`car_id`),
  ADD KEY `FK_Account` (`account_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_account`
--
ALTER TABLE `tbl_account`
  MODIFY `id_account` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_car`
--
ALTER TABLE `tbl_car`
  MODIFY `id_car` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_merk`
--
ALTER TABLE `tbl_merk`
  MODIFY `id_merk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_reserve`
--
ALTER TABLE `tbl_reserve`
  MODIFY `id_reserve` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_car`
--
ALTER TABLE `tbl_car`
  ADD CONSTRAINT `FK_tbl_car_tbl_account` FOREIGN KEY (`account_id`) REFERENCES `tbl_account` (`id_account`),
  ADD CONSTRAINT `FK_tbl_car_tbl_merk` FOREIGN KEY (`merk_id`) REFERENCES `tbl_merk` (`id_merk`);

--
-- Constraints for table `tbl_reserve`
--
ALTER TABLE `tbl_reserve`
  ADD CONSTRAINT `FK_tbl_reserve_tbl_account` FOREIGN KEY (`account_id`) REFERENCES `tbl_account` (`id_account`),
  ADD CONSTRAINT `FK_tbl_reserve_tbl_car` FOREIGN KEY (`car_id`) REFERENCES `tbl_car` (`id_car`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
