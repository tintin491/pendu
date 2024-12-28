-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 15 fév. 2022 à 16:19
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_pendu`
--

-- --------------------------------------------------------

--
-- Structure de la table `difficulte`
--

DROP TABLE IF EXISTS `difficulte`;
CREATE TABLE IF NOT EXISTS `difficulte` (
  `IDDIFFICULTE` int(11) NOT NULL AUTO_INCREMENT,
  `LABELDIFFICULTE` varchar(255) NOT NULL,
  PRIMARY KEY (`IDDIFFICULTE`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `difficulte`
--

INSERT INTO `difficulte` (`IDDIFFICULTE`, `LABELDIFFICULTE`) VALUES
(1, 'Facile'),
(2, 'Moyen'),
(3, 'Difficile'),
(4, 'Enfer');

-- --------------------------------------------------------

--
-- Structure de la table `joueur`
--

DROP TABLE IF EXISTS `joueur`;
CREATE TABLE IF NOT EXISTS `joueur` (
  `IDJOUEUR` int(11) NOT NULL AUTO_INCREMENT,
  `NOMJOUEUR` varchar(255) NOT NULL,
  `PRENOMJOUEUR` varchar(255) NOT NULL,
  `MAILJOUEUR` varchar(255) NOT NULL,
  `PSWDJOUEUR` varchar(255) NOT NULL,
  PRIMARY KEY (`IDJOUEUR`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `mots`
--

DROP TABLE IF EXISTS `mots`;
CREATE TABLE IF NOT EXISTS `mots` (
  `IDMOTS` int(11) NOT NULL AUTO_INCREMENT,
  `LABELMOTS` varchar(255) NOT NULL,
  `IDDIFFICULTE` int(11) NOT NULL,
  PRIMARY KEY (`IDMOTS`),
  UNIQUE KEY `LABELMOTS` (`LABELMOTS`),
  KEY `Mots_Difficulte_FK` (`IDDIFFICULTE`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `mots`
--

INSERT INTO `mots` (`IDMOTS`, `LABELMOTS`, `IDDIFFICULTE`) VALUES
(1, 'Francophile', 3),
(2, 'Chlorophylle', 3),
(3, 'Conspirateur', 3),
(4, 'Qualification', 3),
(5, 'Attraction', 3),
(6, 'Cornemuse', 3),
(7, 'Tourisme', 3),
(8, 'Diapason', 3),
(9, 'Brouhaha', 3),
(10, 'Jeu', 1),
(11, 'Glu', 1),
(12, 'Jet', 1),
(13, 'Rhum', 1),
(14, 'Taie', 1),
(15, 'Taux', 1),
(16, 'Thym', 1),
(17, 'Cire', 1),
(18, 'Ardu', 1),
(19, 'Igloo', 2),
(20, 'Banjo', 2),
(21, 'Tyran', 2),
(22, 'Basson', 2),
(23, 'Faucon', 2),
(24, 'Gospel', 2),
(25, 'Whisky', 2),
(26, 'Azimut', 2),
(27, 'Acajou', 2),
(28, 'ABRACADABRA', 4),
(29, 'AGGRAVATIONS', 4),
(30, 'APOCALYPSES', 4),
(31, 'BACCALAUREATS', 4),
(32, 'BAGUENAUDIERS', 4),
(33, 'BELLIGERANTS', 4),
(34, 'BONNETEAUX', 4),
(35, 'CARABISTOUILLES', 4),
(36, 'CONSTELLATIONS', 4),
(37, 'EXCELLENCES', 4),
(58, 'FIEF', 1),
(59, 'FILOU', 1),
(60, 'FLIBUSTIERS', 4),
(61, 'FUGITIFS', 3),
(62, 'HEXAGONE', 4),
(63, 'MAHARADJAH', 4),
(64, 'ICEBERG', 3),
(65, 'MEDITERRANEE', 4),
(66, 'KALEIDOSCOPES', 4),
(67, 'LIBERTE', 2);

-- --------------------------------------------------------

--
-- Structure de la table `partie`
--

DROP TABLE IF EXISTS `partie`;
CREATE TABLE IF NOT EXISTS `partie` (
  `IDPARTIE` int(11) NOT NULL AUTO_INCREMENT,
  `SCOREPARTIE` double NOT NULL,
  `TEMPSPARTIE` int(11) NOT NULL,
  `NOMBREESSAIT` int(11) NOT NULL,
  `IDJOUEUR` int(11) NOT NULL,
  `IDMOTS` int(11) NOT NULL,
  PRIMARY KEY (`IDPARTIE`),
  KEY `Partie_Joueur_FK` (`IDJOUEUR`),
  KEY `Partie_Mots0_FK` (`IDMOTS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `mots`
--
ALTER TABLE `mots`
  ADD CONSTRAINT `Mots_Difficulte_FK` FOREIGN KEY (`IDDIFFICULTE`) REFERENCES `difficulte` (`IDDIFFICULTE`);

--
-- Contraintes pour la table `partie`
--
ALTER TABLE `partie`
  ADD CONSTRAINT `Partie_Joueur_FK` FOREIGN KEY (`IDJOUEUR`) REFERENCES `joueur` (`IDJOUEUR`),
  ADD CONSTRAINT `Partie_Mots0_FK` FOREIGN KEY (`IDMOTS`) REFERENCES `mots` (`IDMOTS`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
