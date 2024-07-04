-- Inserting data into Matiere table
INSERT INTO Matiere (matiere) VALUES
('Acier'),
('Cuivre'),
('Aluminium'),
('Bois'),
('Plastique');

-- Inserting data into Taille table
INSERT INTO Taille (diametre) VALUES
('Petit'),
('Moyen'),
('Grand'),
('Très Grand'),
('Extra Large');

-- Inserting data into Article table
INSERT INTO Article (nom, categorie, taille_id, matiere_id) VALUES
('Boucle doreille', 'Bijoux', 1, 1),
('Bracelet', 'Bijoux', 2, 2),
('Collier', 'Bijoux', 3, 3),
('Pendentif', 'Bijoux', 1, 4),
('Montre', 'Montres', 2, 5),
('Ceinture', 'Accessoires', 3, 1),
('Porte-feuille', 'Accessoires', 2, 2),
('Sac à main', 'Accessoires', 3, 3);

-- Inserting data into Users table
INSERT INTO Users (nom, prenom, mail, adresse_postale, telephone) VALUES
('Doe', 'John', 'john.doe@example.com', '123 Main St', '0123456789'),
('Doe', 'Jane', 'jane.doe@example.com', '456 Elm St', '0987654321'),
('Smith', 'Bob', 'bob.smith@example.com', '789 Oak St', '5551234567'),
('Johnson', 'Alice', 'alice.johnson@example.com', '321 Pine St', '5559012345'),
('Williams', 'Mike', 'mike.williams@example.com', '901 Maple St', '5551112222');

-- Inserting data into Commande table
INSERT INTO Commande (users_id) VALUES
(1),
(2),
(3),
(4),
(5);

-- Inserting data into CommandeArticle table
INSERT INTO CommandeArticle (commande_id, article_id, quantite) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 3, 3),
(2, 4, 2),
(3, 5, 1),
(3, 6, 2),
(4, 7, 3),
(4, 8, 1),
(5, 1, 1),
(5, 2, 2);

-- Inserting data into Authentification table
INSERT INTO Authentification (login, mot_de_passe) VALUES
('john.doe@example.com', 'password123'),
('jane.doe@example.com', 'password456'),
('bob.smith@example.com', 'password789'),
('alice.johnson@example.com', 'password012'),
('mike.williams@example.com', 'password345');
