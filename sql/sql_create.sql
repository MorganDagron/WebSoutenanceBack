CREATE DATABASE soutenanceAJC;

USE soutenanceAJC;

CREATE TABLE Matiere (
  id INT IDENTITY(1,1) PRIMARY KEY,
  matiere VARCHAR(255)
);

CREATE TABLE Taille (
  id INT IDENTITY(1,1) PRIMARY KEY,
  diametre VARCHAR(255)
);

CREATE TABLE Article (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nom VARCHAR(255),
  categorie VARCHAR(255),
  taille_id INT,
  matiere_id INT,
  FOREIGN KEY (taille_id) REFERENCES Taille(id),
  FOREIGN KEY (matiere_id) REFERENCES Matiere(id)
);

CREATE TABLE Users (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nom VARCHAR(255),
  prenom VARCHAR(255),
  mail VARCHAR(255) UNIQUE,
  adresse_postale VARCHAR(255),
  telephone VARCHAR(255),
  isAdmin BIT
);

CREATE TABLE Commande (
  id INT IDENTITY(1,1) PRIMARY KEY,
  users_id INT,
  FOREIGN KEY (users_id) REFERENCES Users(id)
);

CREATE TABLE CommandeArticle (
  commande_id INT,
  article_id INT,
  quantite INT,
  PRIMARY KEY (commande_id, article_id),
  FOREIGN KEY (commande_id) REFERENCES Commande(id),
  FOREIGN KEY (article_id) REFERENCES Article(id)
);

CREATE TABLE Authentification (
  login VARCHAR(255) PRIMARY KEY,
  mot_de_passe VARCHAR(255),
  FOREIGN KEY (login) REFERENCES Users(mail)
);

CREATE TABLE BlogArticle (
  id INT IDENTITY(1,1) PRIMARY KEY,
  imageUrl VARCHAR(255),
  titre VARCHAR(255),
  contenu TEXT,
  creationDate DATETIME,
  categorie VARCHAR(255)
);

CREATE TABLE Comments (
  id INT IDENTITY(1,1) PRIMARY KEY,
  titre VARCHAR(255),
  contenu TEXT,
  creationDate DATETIME,
  idUser INT,
  IdArticle INT,
  FOREIGN KEY (article_id) REFERENCES Article(id),
  FOREIGN KEY (users_id) REFERENCES Users(id)
);
