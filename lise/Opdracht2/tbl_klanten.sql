-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Genereertijd: 21 nov 2013 om 20:50
-- Serverversie: 5.5.32
-- PHP-versie: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `opdracht2`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `tbl_klanten`
--

CREATE TABLE IF NOT EXISTS `tbl_klanten` (
  `Klanten_nummer` int(11) NOT NULL AUTO_INCREMENT,
  `Naam` text NOT NULL,
  `Adres` text NOT NULL,
  `Postnr` int(11) NOT NULL,
  `Gemeente` text NOT NULL,
  `InteresseBoeken` text NOT NULL,
  `InteresseDVDs` text NOT NULL,
  `InteresseCds` text NOT NULL,
  PRIMARY KEY (`Klanten_nummer`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Gegevens worden uitgevoerd voor tabel `tbl_klanten`
--

INSERT INTO `tbl_klanten` (`Klanten_nummer`, `Naam`, `Adres`, `Postnr`, `Gemeente`, `InteresseBoeken`, `InteresseDVDs`, `InteresseCds`) VALUES
(1, 'Lise Proost', 'Boomstraat 26', 2300, 'Turnhout', 'j', 'j', 'n'),
(2, 'Kristin Luyckx', 'Graatakker 2', 2300, 'Turnhout', 'j', 'n', 'n');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
