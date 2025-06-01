-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 01 juin 2025 à 14:53
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionstage`
--

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

CREATE TABLE `compte` (
  `id` int(11) NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `profilPath` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`id`, `login`, `password`, `profilPath`) VALUES
(1, 'durand.jean', 'durand1234', '../../assets/personnage-homme.jpg'),
(2, 'martin.sophie', 'martin1234', '../../assets/personnage-femme.jpg'),
(3, 'leclerc.paul', 'leclerc1234', '../../assets/personnage-homme.jpg'),
(4, 'terkhi.ali', 'terkhi1234', '../../assets/personnage-homme.jpg'),
(5, 'rio.toto', 'rio1234', '../../assets/personnage-femme.jpg'),
(6, 'fernandez.roberto', 'fernandez1234', '../../assets/personnage-homme.jpg'),
(7, 'petit.lucas', 'petit1234', '../../assets/personnage-homme.jpg'),
(8, 'root', 'root', '../../assets/personnage-homme.jpg'),
(9, 'moreau.emma', 'moreau1234', '../../assets/personnage-femme.jpg'),
(10, 'dubois.hugo', 'dubois1234', '../../assets/personnage-homme.jpg'),
(11, 'lemoine.ines', 'lemoine1234', '../../assets/personnage-femme.jpg'),
(12, 'garcia.nina', 'garcia1234', '../../assets/personnage-femme.jpg'),
(13, 'roux.ethan', 'roux1234', '../../assets/personnage-homme.jpg'),
(14, 'lopez.lea', 'lopez1234', '../../assets/personnage-femme.jpg'),
(15, 'henry.tom', 'henry1234', '../../assets/personnage-homme.jpg'),
(16, 'cohen.jade', 'cohen1234', '../../assets/personnage-femme.jpg'),
(17, 'faure.noah', 'faure1234', '../../assets/personnage-homme.jpg'),
(18, 'marchand.zoe', 'marchand1234', '../../assets/personnage-femme.jpg'),
(19, 'bertrand.lina', 'bertrand1234', '../../assets/personnage-femme.jpg'),
(20, 'robin.adam', 'robin1234', '../../assets/personnage-homme.jpg'),
(21, 'garnier.eva', 'garnier1234', '../../assets/personnage-femme.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE `eleve` (
  `idElv` int(11) NOT NULL,
  `nomElv` varchar(30) DEFAULT NULL,
  `prenomElv` varchar(30) DEFAULT NULL,
  `email` varchar(125) DEFAULT NULL,
  `tel` int(10) DEFAULT NULL,
  `nomPoste` varchar(125) DEFAULT NULL,
  `sectionOption` int(100) DEFAULT NULL,
  `rueElv` varchar(120) DEFAULT NULL,
  `cpElv` varchar(5) DEFAULT NULL,
  `villeElv` varchar(20) DEFAULT NULL,
  `idCpt` int(11) DEFAULT NULL,
  `urlPortfolio` varchar(120) DEFAULT NULL,
  `pathCV` varchar(150) DEFAULT NULL,
  `lieuTravail` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`idElv`, `nomElv`, `prenomElv`, `email`, `tel`, `nomPoste`, `sectionOption`, `rueElv`, `cpElv`, `villeElv`, `idCpt`, `urlPortfolio`, `pathCV`, `lieuTravail`) VALUES
(1, 'Durand', 'Jean', NULL, NULL, NULL, 1, '135 Rue de la Liberté', '13001', 'Marseille', 1, NULL, NULL, 'Partiel'),
(2, 'Martin', 'Sophie', NULL, NULL, NULL, 2, '2 Rue de la République', '13008', 'Marseille', 2, NULL, NULL, 'Sur Site'),
(3, 'Leclerc', 'Paul', NULL, NULL, NULL, 4, '6 Boulevard des Alpes', '13400', 'Aubagne', 3, NULL, NULL, 'Partiel'),
(4, 'Terkhi', 'Ali', NULL, NULL, NULL, 3, '62 Avenue Frederic Mistral', '13110', 'Port-de-Bouc', 4, NULL, NULL, 'Distanciel'),
(5, 'Rio', 'Toto', NULL, NULL, NULL, 2, '255 chemin de la duranne', '13230', 'Port-st-louis', 5, 'Liens Portfolio...', '../../assets/CV.pdf', 'Sur Site'),
(6, 'Fernandez', 'Roberto', NULL, NULL, NULL, 4, '1 Rue des Palmiers', '13009', 'Marseille', 6, NULL, NULL, 'Sur Site'),
(7, 'Petit', 'Lucas', NULL, NULL, NULL, 1, '10 Rue des Lilas', '13002', 'Marseille', 7, NULL, NULL, 'Sur Site'),
(8, 'Moreau', 'Emma', NULL, NULL, NULL, 2, '22 Rue Paradis', '13006', 'Marseille', 8, NULL, NULL, 'Distanciel'),
(9, 'Dubois', 'Hugo', NULL, NULL, NULL, 3, '5 Chemin du Moulin', '13100', 'Aix-en-Provence', 9, NULL, NULL, 'Partiel'),
(10, 'Lemoine', 'Inès', NULL, NULL, NULL, 4, '89 Avenue Victor Hugo', '13003', 'Marseille', 10, NULL, NULL, 'Sur Site'),
(11, 'Garcia', 'Nina', NULL, NULL, NULL, 1, '12 Rue Belle Vue', '13004', 'Marseille', 11, NULL, NULL, 'Sur Site'),
(12, 'Roux', 'Ethan', NULL, NULL, NULL, 2, '41 Rue Saint-Ferréol', '13005', 'Marseille', 12, NULL, NULL, 'Partiel'),
(13, 'Lopez', 'Léa', NULL, NULL, NULL, 3, '7 Impasse du Sud', '13006', 'Marseille', 13, NULL, NULL, 'Distanciel'),
(14, 'Henry', 'Tom', NULL, NULL, NULL, 4, '3 Allée des Pins', '13007', 'Marseille', 14, NULL, NULL, 'Sur Site'),
(15, 'Cohen', 'Jade', NULL, NULL, NULL, 1, '19 Rue Sainte', '13008', 'Marseille', 15, NULL, NULL, 'Sur Site'),
(16, 'Faure', 'Noah', NULL, NULL, NULL, 2, '16 Rue de la République', '13001', 'Marseille', 16, NULL, NULL, 'Distanciel'),
(17, 'Marchand', 'Zoé', NULL, NULL, NULL, 3, '8 Rue Breteuil', '13006', 'Marseille', 17, NULL, NULL, 'Partiel'),
(18, 'Bertrand', 'Lina', NULL, NULL, NULL, 4, '4 Boulevard Longchamp', '13004', 'Marseille', 18, NULL, NULL, 'Sur Site'),
(19, 'Robin', 'Adam', NULL, NULL, NULL, 1, '33 Rue des Docks', '13002', 'Marseille', 19, NULL, NULL, 'Sur Site'),
(20, 'Garnier', 'Eva', NULL, NULL, NULL, 2, '21 Rue Consolat', '13001', 'Marseille', 20, NULL, NULL, 'Distanciel');

-- --------------------------------------------------------

--
-- Structure de la table `entreprise`
--

CREATE TABLE `entreprise` (
  `idEtp` int(11) NOT NULL,
  `nomEtp` varchar(50) DEFAULT NULL,
  `rueEtp` varchar(120) DEFAULT NULL,
  `cpEtp` varchar(5) DEFAULT NULL,
  `villeEtp` varchar(20) DEFAULT NULL,
  `mailEtp` varchar(50) DEFAULT NULL,
  `telEtp` varchar(15) DEFAULT NULL,
  `activiteEtp` varchar(50) DEFAULT NULL,
  `ImgEtp` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `entreprise`
--

INSERT INTO `entreprise` (`idEtp`, `nomEtp`, `rueEtp`, `cpEtp`, `villeEtp`, `mailEtp`, `telEtp`, `activiteEtp`, `ImgEtp`) VALUES
(1, 'TechNova', '10 rue des Sciences', '75000', 'Paris', 'contact@technova.fr', '0102030405', 'Développement logiciel', 'https://technova.fr/logo.png'),
(2, 'Coorty', '21 rue marc Donadille ', '13013', 'Marseille', 'co@coorty.fr', '0491257575', 'Créateur de logiciels', 'https://media.licdn.com/dms/image/C560BAQG8QKqRQm3mMA/company-logo_200_200/0/1529328706444?e=2147483647&v=beta&t=7GZ18X4RmKy_urTqLEHhDG1LbU7IBYUTwVRyDt1qmr0'),
(3, 'Artonik', '164 Cours Lieutaud', '13006', 'Marseille', 'artonik.pro@gmail.com', '0490906880', 'Concepteur technologique', 'https://www.artonik.com/WebSkin/Artonik/images/slider/slide1.png'),
(4, 'SARL KMS', '46 BD Federation', '13004', 'Marseille', 'contact@kms.fr', '0491345020', 'centre culturel', 'https://www.kms.fr/images/Logo_KMS_Def.Png'),
(5, 'Naturex SA', '250 rue pierre bayle', '84911', 'Avignon', 'naturex@naturex.com', '0490239689', 'Pharmacie', 'https://www.agro-media.fr/wp-content/uploads/2012/01/une-croissance-de-12-pourcents-pour-naturex.png'),
(6, 'Circet SA', '13 Immeuble Les Baux', '13420', 'Gémenos', 'co@circet.fr', '0412131415', 'Services telephoniques', 'https://www.circet.fr/fileadmin/_processed_/e/2/csm_circet_france_f314466a96.png');

-- --------------------------------------------------------

--
-- Structure de la table `intervenir`
--

CREATE TABLE `intervenir` (
  `idProf` int(20) NOT NULL,
  `idClasse` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `intervenir`
--

INSERT INTO `intervenir` (`idProf`, `idClasse`) VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 1),
(3, 4),
(4, 2);

-- --------------------------------------------------------

--
-- Structure de la table `lieutravail`
--

CREATE TABLE `lieutravail` (
  `nom` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `lieutravail`
--

INSERT INTO `lieutravail` (`nom`) VALUES
('Distanciel'),
('Partiel'),
('Sur Site');

-- --------------------------------------------------------

--
-- Structure de la table `professeur`
--

CREATE TABLE `professeur` (
  `idProf` int(11) NOT NULL,
  `nomProf` varchar(30) DEFAULT NULL,
  `prenomProf` varchar(30) DEFAULT NULL,
  `matiereProf` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `professeur`
--

INSERT INTO `professeur` (`idProf`, `nomProf`, `prenomProf`, `matiereProf`) VALUES
(1, 'Lemoine', 'Claire', 'Base de données'),
(2, 'Demede', 'Michel', 'Informatique développement'),
(3, 'Tormento', 'Sylvie', 'Informatique développement'),
(4, 'Markovitch', 'Yan', 'Informatique réseau'),
(5, 'Girard', 'Élodie', 'Communication professionnelle'),
(6, 'Delorme', 'Stéphane', 'Culture économique et juridiqu'),
(7, 'Marechal', 'Camille', 'Comptabilité'),
(8, 'Faivre', 'Julien', 'Anglais professionnel'),
(9, 'Bernard', 'Amandine', 'Gestion de projet'),
(10, 'Roux', 'Luc', 'Cybersécurité');

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE `specialite` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `specialite`
--

INSERT INTO `specialite` (`id`, `nom`) VALUES
(1, 'BTS-MCO'),
(2, 'BTS-SAM'),
(3, 'BTS-SIO-SISR'),
(4, 'BTS-SIO-SLAM');

-- --------------------------------------------------------

--
-- Structure de la table `stagecandidature`
--

CREATE TABLE `stagecandidature` (
  `idStage` int(11) NOT NULL,
  `idElv` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `stagecandidature`
--

INSERT INTO `stagecandidature` (`idStage`, `idElv`) VALUES
(1, 5),
(2, 5);

-- --------------------------------------------------------

--
-- Structure de la table `stagehistoric`
--

CREATE TABLE `stagehistoric` (
  `idStage` int(11) NOT NULL,
  `idElv` int(11) NOT NULL,
  `idTuteur` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `dateDebut` date NOT NULL,
  `dateFin` date NOT NULL,
  `poste` varchar(50) NOT NULL,
  `etat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `stagehistoric`
--

INSERT INTO `stagehistoric` (`idStage`, `idElv`, `idTuteur`, `idProf`, `dateDebut`, `dateFin`, `poste`, `etat`) VALUES
(1, 5, 3, 2, '2025-05-01', '2025-06-01', 'Developpeur FullStack Junior', 0),
(2, 5, 1, 5, '2025-02-01', '2025-03-04', 'Developpeur back-end', 1),
(3, 8, 6, 10, '2025-04-01', '2025-05-01', 'Commercial relation B2B', 1),
(4, 13, 2, 5, '2025-04-01', '2025-05-01', 'Comptable Junior', 1),
(5, 11, 4, 4, '2025-05-01', '2025-06-01', 'Administrateur réseaux', 0),
(6, 9, 5, 3, '2025-01-01', '2025-02-01', 'Développeur moteur graphique', 1);

-- --------------------------------------------------------

--
-- Structure de la table `stagesapourvoir`
--

CREATE TABLE `stagesapourvoir` (
  `idStage` int(11) NOT NULL,
  `titre` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `lieu` varchar(100) DEFAULT NULL,
  `dateDebut` date DEFAULT NULL,
  `dureeSemaines` int(11) DEFAULT NULL,
  `idEtp` int(11) DEFAULT NULL,
  `idProf` int(11) DEFAULT NULL,
  `idTut` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `stagesapourvoir`
--

INSERT INTO `stagesapourvoir` (`idStage`, `titre`, `description`, `lieu`, `dateDebut`, `dureeSemaines`, `idEtp`, `idProf`, `idTut`) VALUES
(1, 'Développeur .NET Junior', 'Participation à un projet en C# avec Windows Forms.', 'Marseille', '2025-06-10', 6, 1, 3, 2),
(2, 'Technicien Réseau', 'Configuration de routeurs/switchs en PME.', 'Aix-en-Provence', '2025-07-01', 8, 4, 4, 5),
(3, 'Assistant Cybersécurité', 'Analyse des failles et tests de vulnérabilité.', 'Avignon', '2025-06-20', 5, 5, 5, 3),
(4, 'Développeur Full-Stack', 'Création de la boutique en ligne', 'Paris 2eme', '2025-06-01', 3, 5, 9, 3),
(5, 'Technicien support informatique', 'Aide au support ticket et réseaux', 'Ajaccio', '2025-06-08', 6, 2, 3, 4);

-- --------------------------------------------------------

--
-- Structure de la table `tuteur`
--

CREATE TABLE `tuteur` (
  `idTut` int(11) NOT NULL,
  `nomTut` varchar(20) DEFAULT NULL,
  `prenomTut` varchar(20) DEFAULT NULL,
  `telTut` varchar(15) DEFAULT NULL,
  `idEtp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `tuteur`
--

INSERT INTO `tuteur` (`idTut`, `nomTut`, `prenomTut`, `telTut`, `idEtp`) VALUES
(1, 'Verdier', 'Luc', '0601020304', 1),
(2, 'Parizot', 'Bruno', '0614691732', 1),
(3, 'Bayet', 'Alain', '0666589632', 5),
(4, 'Gerster', 'Julien', '0666666666', 2),
(5, 'Palazzolo', 'Bruno', '0728693122', 4),
(6, 'Schicchi', 'Julien', '0663281632', 6),
(7, 'Paoli', 'Pascal', '0719130394', 3);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `compte`
--
ALTER TABLE `compte`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD PRIMARY KEY (`idElv`),
  ADD KEY `fk_compte` (`idCpt`),
  ADD KEY `fk_sectionOption` (`sectionOption`),
  ADD KEY `fk_lieuTravail` (`lieuTravail`);

--
-- Index pour la table `entreprise`
--
ALTER TABLE `entreprise`
  ADD PRIMARY KEY (`idEtp`);

--
-- Index pour la table `intervenir`
--
ALTER TABLE `intervenir`
  ADD PRIMARY KEY (`idProf`,`idClasse`),
  ADD KEY `fk_IdClasse` (`idClasse`);

--
-- Index pour la table `lieutravail`
--
ALTER TABLE `lieutravail`
  ADD PRIMARY KEY (`nom`);

--
-- Index pour la table `professeur`
--
ALTER TABLE `professeur`
  ADD PRIMARY KEY (`idProf`);

--
-- Index pour la table `specialite`
--
ALTER TABLE `specialite`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `stagecandidature`
--
ALTER TABLE `stagecandidature`
  ADD PRIMARY KEY (`idStage`,`idElv`),
  ADD KEY `idElv` (`idElv`);

--
-- Index pour la table `stagehistoric`
--
ALTER TABLE `stagehistoric`
  ADD PRIMARY KEY (`idStage`),
  ADD KEY `fk_idElv` (`idElv`),
  ADD KEY `fk_idTuteur` (`idTuteur`),
  ADD KEY `idProf` (`idProf`);

--
-- Index pour la table `stagesapourvoir`
--
ALTER TABLE `stagesapourvoir`
  ADD PRIMARY KEY (`idStage`),
  ADD KEY `idEtp` (`idEtp`),
  ADD KEY `idProf` (`idProf`),
  ADD KEY `fk_idTut` (`idTut`);

--
-- Index pour la table `tuteur`
--
ALTER TABLE `tuteur`
  ADD PRIMARY KEY (`idTut`),
  ADD KEY `idEtp` (`idEtp`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `compte`
--
ALTER TABLE `compte`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table `eleve`
--
ALTER TABLE `eleve`
  MODIFY `idElv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pour la table `entreprise`
--
ALTER TABLE `entreprise`
  MODIFY `idEtp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `professeur`
--
ALTER TABLE `professeur`
  MODIFY `idProf` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `specialite`
--
ALTER TABLE `specialite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `stagehistoric`
--
ALTER TABLE `stagehistoric`
  MODIFY `idStage` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `stagesapourvoir`
--
ALTER TABLE `stagesapourvoir`
  MODIFY `idStage` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `tuteur`
--
ALTER TABLE `tuteur`
  MODIFY `idTut` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `fk_compte` FOREIGN KEY (`idCpt`) REFERENCES `compte` (`id`),
  ADD CONSTRAINT `fk_lieuTravail` FOREIGN KEY (`lieuTravail`) REFERENCES `lieutravail` (`nom`),
  ADD CONSTRAINT `fk_sectionOption` FOREIGN KEY (`sectionOption`) REFERENCES `specialite` (`id`);

--
-- Contraintes pour la table `intervenir`
--
ALTER TABLE `intervenir`
  ADD CONSTRAINT `fk_IdClasse` FOREIGN KEY (`idClasse`) REFERENCES `specialite` (`id`),
  ADD CONSTRAINT `fk_IdProf` FOREIGN KEY (`idProf`) REFERENCES `professeur` (`idProf`);

--
-- Contraintes pour la table `stagecandidature`
--
ALTER TABLE `stagecandidature`
  ADD CONSTRAINT `stagecandidature_ibfk_1` FOREIGN KEY (`idElv`) REFERENCES `eleve` (`idElv`);

--
-- Contraintes pour la table `stagehistoric`
--
ALTER TABLE `stagehistoric`
  ADD CONSTRAINT `fk_idElv` FOREIGN KEY (`idElv`) REFERENCES `eleve` (`idElv`),
  ADD CONSTRAINT `fk_idTuteur` FOREIGN KEY (`idTuteur`) REFERENCES `tuteur` (`idTut`),
  ADD CONSTRAINT `stagehistoric_ibfk_1` FOREIGN KEY (`idProf`) REFERENCES `professeur` (`idProf`);

--
-- Contraintes pour la table `stagesapourvoir`
--
ALTER TABLE `stagesapourvoir`
  ADD CONSTRAINT `fk_idEtp` FOREIGN KEY (`idEtp`) REFERENCES `entreprise` (`idEtp`),
  ADD CONSTRAINT `fk_idTut` FOREIGN KEY (`idTut`) REFERENCES `tuteur` (`idTut`),
  ADD CONSTRAINT `stagesapourvoir_ibfk_1` FOREIGN KEY (`idProf`) REFERENCES `professeur` (`idProf`);

--
-- Contraintes pour la table `tuteur`
--
ALTER TABLE `tuteur`
  ADD CONSTRAINT `tuteur_ibfk_1` FOREIGN KEY (`idEtp`) REFERENCES `entreprise` (`idEtp`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
