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
INSERT INTO Users (nom, prenom, mail, adresse_postale, telephone, isAdmin) VALUES
('Doe', 'John', 'john.doe@example.com', '123 Main St', '0123456789', 0),
('Doe', 'Jane', 'jane.doe@example.com', '456 Elm St', '0987654321', 0),
('Smith', 'Bob', 'bob.smith@example.com', '789 Oak St', '5551234567', 0),
('Johnson', 'Alice', 'alice.johnson@example.com', '321 Pine St', '5559012345', 0),
('Williams', 'Mike', 'mike.williams@example.com', '901 Maple St', '5551112222', 0),
('admin', 'admin', 'admin@example.com', '', '', 1);

-- Inserting data into Commande table
INSERT INTO Commande (mail) VALUES
('john.doe@example.com'),
('jane.doe@example.com'),
('bob.smith@example.com'),
('alice.johnson@example.com'),
('mike.williams@example.com');

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
('mike.williams@example.com', 'password345'),
('admin@example.com','admin');

-- Inserting data into BlogArticle table
INSERT INTO BlogArticle (imageUrl, titre, contenu, creationDate, categorie) VALUES
('https://picsum.photos/200/300', 'Les dernières tendances en bijoux', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet nulla auctor, vestibulum magna sed, convallis ex.', 2022-01-01, 'Bijoux'),
('https://picsum.photos/200/301', 'Les avantages du cuivre dans les accessoires', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet nulla auctor, vestibulum magna sed, convallis ex.', 2022-01-15, 'Accessoires'),
('https://picsum.photos/200/302', 'La mode des montres cette saison', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet nulla auctor, vestibulum magna sed, convallis ex.', 2022-02-01, 'Montres'),
('https://picsum.photos/200/303', 'Les nouvelles arrivées en matière de sacs à main', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet nulla auctor, vestibulum magna sed, convallis ex.', 2022-03-01, 'Accessoires'),
('https://picsum.photos/200/304', 'Les bijoux de luxe pour les occasions spéciales', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet nulla auctor, vestibulum magna sed, convallis ex.', 2022-04-01, 'Bijoux');

-- Inserting data into Comments table
INSERT INTO Comments (titre, contenu, creationDate, users_id, article_id) VALUES
('Super article !', 'J''ai vraiment apprécié cet article sur les dernières tendances en bijoux.', 2022-01-05, 1, 1),
('Intéressant !', 'Je ne savais pas que le cuivre avait autant d''avantages dans les accessoires.', 2022-01-20, 2, 2),
('J''adore !', 'Je suis fan de montres et cet article m''a donné des idées pour mon prochain achat.', 2022-02-10, 3, 3),
('Très utile !', 'Merci pour les conseils sur les sacs à main, j''en ai besoin pour mon prochain achat.', 2022-03-15, 4, 4),
('Magnifique !', 'Les bijoux de luxe présentés dans cet article sont vraiment incroyables.', 2022-04-10, 5, 5),
('Question ?', 'Pouvez-vous me donner plus d''informations sur les matériaux utilisés dans les bijoux de luxe ?', 2022-04-15, 1, 5);
