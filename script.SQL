-- Table Classe (créée en premier pour les références depuis Eleve et Prof)
CREATE TABLE Classe (
    idClasseElv INT(3) AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(25) NOT NULL
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Entreprise (créée en premier pour la référence depuis Eleve)
CREATE TABLE Entreprise (
    idEntr INT(3) AUTO_INCREMENT PRIMARY KEY,
    nomEntr VARCHAR(25) NOT NULL,
    adRueEntr VARCHAR(50),
    ville VARCHAR(20),
    codePost INT(5),
    telEntr INT(10),
    emailEntr VARCHAR(50),
    secteurEntr VARCHAR(50),
    pathLogoEntr VARCHAR(50),
    refEntre VARCHAR(50)
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Eleve
CREATE TABLE Eleve (
    idElv INT(3) AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(25) NOT NULL,
    prenom VARCHAR(25) NOT NULL,
    dateNaiss DATE,
    pathCV VARCHAR(50),
    forma VARCHAR(10),
    options VARCHAR(10),
    pathPDP VARCHAR(50),
    ville VARCHAR(25),
    adresse VARCHAR(25),
    codePost INT(5),
    tel INT(10),
    email VARCHAR(100),
    idClasseElv INT(3),
    idEntr INT(3),
    FOREIGN KEY (idClasseElv) REFERENCES Classe(idClasseElv),
    FOREIGN KEY (idEntr) REFERENCES Entreprise(idEntr)
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Prof
CREATE TABLE Prof (
    idProf INT(3) AUTO_INCREMENT PRIMARY KEY,
    idClasseProf INT(3),
    nom VARCHAR(25) NOT NULL,
    prenom VARCHAR(25) NOT NULL,
    pathPDP VARCHAR(50),
    ville VARCHAR(25),
    adresse VARCHAR(25),
    codePost INT(5),
    tel INT(10),
    email VARCHAR(100),
    FOREIGN KEY (idClasseProf) REFERENCES Classe(idClasseElv)
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Stage
CREATE TABLE Stage (
    idStageTut INT(3) AUTO_INCREMENT PRIMARY KEY,
    idStageElv INT(3),
    idStageProf INT(3),
    debStage DATE,
    finStage DATE,
    FOREIGN KEY (idStageElv) REFERENCES Eleve(idElv),
    FOREIGN KEY (idStageProf) REFERENCES Prof(idProf)
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Tuteur
CREATE TABLE Tuteur (
    idTut INT(3) AUTO_INCREMENT PRIMARY KEY,
    idTutEntre INT(3),
    nom VARCHAR(25) NOT NULL,
    prenom VARCHAR(25) NOT NULL,
    pathPDP VARCHAR(50),
    tel INT(10),
    email VARCHAR(100),
    FOREIGN KEY (idTutEntre) REFERENCES Entreprise(idEntr)
) ENGINE=InnoDB CHARACTER SET utf8;

-- Table Secteur
CREATE TABLE Secteur (
    idSecteur INT(3) AUTO_INCREMENT PRIMARY KEY,
    labSecteur VARCHAR(50) NOT NULL
) ENGINE=InnoDB CHARACTER SET utf8;
