-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Genereertijd: 27 nov 2013 om 14:08
-- Serverversie: 5.5.32
-- PHP-versie: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `opdracht3`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_klanten`
--

CREATE TABLE IF NOT EXISTS `tbl_klanten` (
  `Klanten_nummer` int(6) NOT NULL,
  `Naam` text NOT NULL,
  `Adres` text NOT NULL,
  `Postnr` text NOT NULL,
  `Gemeente` text NOT NULL,
  `Vorige_meterstand` int(4) NOT NULL,
  `Huidige_meterstand` int(4) NOT NULL,
  `Provincie` text NOT NULL,
  `Aantal_gezinsleden` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `tbl_klanten`
--

INSERT INTO `tbl_klanten` (`Klanten_nummer`, `Naam`, `Adres`, `Postnr`, `Gemeente`, `Vorige_meterstand`, `Huidige_meterstand`, `Provincie`, `Aantal_gezinsleden`) VALUES
(123456, 'Jef', 'Boomstraat 26', '2300', 'Turnhout', 1450, 2100, 'LBG', 6);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
