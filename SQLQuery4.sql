CREATE DATABASE ArtManagementSystem;

GO
USE ArtManagementSystem;




CREATE TABLE Artists (
    ArtistID int primary key,
    
	FirstName varchar(50) not null,
	LastName varchar(50) not null,


	Password varchar(100) not null,
    Email varchar (100) unique,
    Nationality varchar(50),
  
);


CREATE TABLE Artworks (
    ArtworkID int primary key,
    Title varchar(100) not null,
   
    Dimensions varchar(100),
	CreationDate date  not null,
	Description varchar(100),

   
    ArtistID int,
    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID) ON DELETE SET NULL
);


CREATE TABLE  Users(
    UserID int primary key,
	Password varchar(100) not  null,

    Name varchar(100)not null,
    Email varchar(100) unique,
);

CREATE TABLE  Ownership (
    RecordID int  primary key(RecordID,UserID),
	UserID int ,

    ArtworkID int not null unique,
	Price bigint not null, 
    OwnershipDate date not null,
    FOREIGN KEY (ArtworkID) REFERENCES Artworks(ArtworkID) ON DELETE CASCADE,
	 FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
   );


CREATE TABLE Galleries (
    GalleryID int  primary key,
	Password varchar(100) not null ,
    Name varchar(100) not null ,
    Location varchar(100) ,
    ContactInfo varchar(100) unique ,
);


CREATE TABLE Exhibitions (
    ExhibitionID int primary key,
    Name varchar(100) not null,
    StartDate date,
    EndDate date,

    GalleryID int not null,
	ArtworkID int not null,

	FOREIGN KEY (ArtworkID) REFERENCES Artworks(ArtworkID) ON DELETE CASCADE,

    FOREIGN KEY (GalleryID) REFERENCES Galleries(GalleryID) ON DELETE CASCADE
);





CREATE TABLE Reviews (
    ReviewID int not null,
    UserID int not null,
    ArtworkID int not null,
	primary key(  ReviewID, UserID, ArtworkID),
	Comment varchar(100),
    Rating int not null,
	);
CREATE TABLE VerificationRequest (
    RequestID int not null,
    UserID int not null,
    ArtworkID int not null,
	primary key(  RequestID, UserID, ArtworkID),
	RequestDate date,
    VerificationStatus varchar(50) not null,
	);	

	CREATE TABLE AuctionHouse (
    AuctionID int not null,
    GalleryID int not null,
    ArtworkID int not null,
	primary key( AuctionID,GalleryID),
	Name varchar(100) not null,
    StartingPrice bigint not null,
	);	
	
	
  INSERT INTO Artists(ArtistID, FirstName, LastName, Password, Email, Nationality) VALUES
(1, 'Pablo', 'Picasso', 'password123', 'picasso@mail.com', 'Spanish'),
(2, 'Leonardo', 'da Vinci', 'password123', 'davinci@mail.com', 'Italian'),
(3, 'Vincent', 'van Gogh', 'password123', 'vangogh@mail.com', 'Dutch'),
(4, 'Claude', 'Monet', 'password123', 'monet@mail.com', 'French'),
(5, 'Salvador', 'Dali', 'password123', 'dali@mail.com', 'Spanish'),
(6, 'Frida', 'Kahlo', 'password123', 'kahlo@mail.com', 'Mexican'),
(7, 'Andy', 'Warhol', 'password123', 'warhol@mail.com', 'American'),
(8, 'Georgia', 'O’Keeffe', 'password123', 'okeeffe@mail.com', 'American'),
(9, 'Edvard', 'Munch', 'password123', 'munch@mail.com', 'Norwegian'),
(10, 'Jackson', 'Pollock', 'password123', 'pollock@mail.com', 'American'),
(11, 'Henri', 'Matisse', 'password123', 'matisse@mail.com', 'French'),
(12, 'Paul', 'Cezanne', 'password123', 'cezanne@mail.com', 'French'),
(13, 'Michelangelo', 'Buonarroti', 'password123', 'michelangelo@mail.com', 'Italian'),
(14, 'Rembrandt', 'van Rijn', 'password123', 'rembrandt@mail.com', 'Dutch'),
(15, 'Raphael', 'Sanzio', 'password123', 'raphael@mail.com', 'Italian'),
(16, 'Joan', 'Miró', 'password123', 'miro@mail.com', 'Spanish'),
(17, 'Diego', 'Rivera', 'password123', 'rivera@mail.com', 'Mexican'),
(18, 'Yayoi', 'Kusama', 'password123', 'kusama@mail.com', 'Japanese'),
(19, 'Wassily', 'Kandinsky', 'password123', 'kandinsky@mail.com', 'Russian'),
(20, 'Piet', 'Mondrian', 'password123', 'mondrian@mail.com', 'Dutch');


INSERT INTO Artworks (ArtworkID, Title, Dimensions, CreationDate, Description, ArtistID) VALUES
(1, 'The Persistence of Memory', '24x33 cm', '1931-01-01', 'Famous surrealist painting', 5),
(2, 'The Starry Night', '73.7x92.1 cm', '1889-06-01', 'Depicts a night sky swirling with energy', 3),
(3, 'The Last Supper', '460x880 cm', '1498-01-01', 'Depicts the final meal of Jesus with his apostles', 2),
(4, 'Mona Lisa', '77x53 cm', '1503-01-01', 'Portrait of a woman with an enigmatic expression', 2),
(5, 'Guernica', '349x777 cm', '1937-01-01', 'Anti-war masterpiece', 1),
(6, 'Water Lilies', '200x300 cm', '1919-01-01', 'Impressionist painting of water lilies', 4),
(7, 'The Scream', '91x73 cm', '1893-01-01', 'Expressionist painting of a figure on a bridge', 9),
(8, 'The Creation of Adam', '280x570 cm', '1512-01-01', 'Fresco painting from the Sistine Chapel', 13),
(9, 'Girl with a Pearl Earring', '46.5x40 cm', '1665-01-01', 'Dutch Golden Age portrait', 14),
(10, 'The Night Watch', '363x437 cm', '1642-01-01', 'Military group portrait', 14),
(11, 'Campbell’s Soup Cans', '51x41 cm', '1962-01-01', 'Pop art representation of soup cans', 7),
(12, 'Self-Portrait with Thorn Necklace', '61x47 cm', '1940-01-01', 'Autobiographical work', 6),
(13, 'Sunflowers', '92x73 cm', '1888-01-01', 'Still life painting of sunflowers', 3),
(14, 'Composition VIII', '140x201 cm', '1923-01-01', 'Abstract geometric art', 19),
(15, 'Broadway Boogie Woogie', '127x127 cm', '1943-01-01', 'Abstract depiction of New York', 20),
(16, 'The Kiss', '180x180 cm', '1907-01-01', 'Symbolist masterpiece', 8),
(17, 'Two Fridas', '173x173 cm', '1939-01-01', 'Surrealist double self-portrait', 6),
(18, 'Impression, Sunrise', '48x63 cm', '1872-01-01', 'Inspired the name of Impressionism', 4),
(19, 'Les Demoiselles d’Avignon', '244x233 cm', '1907-01-01', 'Proto-Cubist masterpiece', 1),
(20, 'The Weeping Woman', '60x49 cm', '1937-01-01', 'Portrait of a grief-stricken woman', 1),
(21, 'Irises', '71x93 cm', '1889-05-01', 'Vibrant still life of irises', 3),
(22, 'The Garden of Earthly Delights', '220x389 cm', '1500-01-01', 'Surreal triptych painting', 2),
(23, 'Starry Night Over the Rhône', '72x92 cm', '1888-09-01', 'Nighttime river scene', 3),
(24, 'The Hay Wain', '130x185 cm', '1821-01-01', 'Pastoral landscape', 15),
(25, 'American Gothic', '74x62 cm', '1930-01-01', 'Iconic portrait of a farmer and his wife', 8),
(26, 'No. 5, 1948', '243x121 cm', '1948-01-01', 'Abstract expressionist painting', 10),
(27, 'Blue Poles', '210x490 cm', '1952-01-01', 'Abstract expressionism at its peak', 10),
(28, 'Portrait of Adele Bloch-Bauer I', '138x138 cm', '1907-01-01', 'Golden portrait of Adele Bloch-Bauer', 4),
(29, 'A Sunday Afternoon on the Island of La Grande Jatte', '207x308 cm', '1884-01-01', 'Pointillist masterpiece', 11),
(30, 'Las Meninas', '318x276 cm', '1656-01-01', 'Intriguing Spanish Baroque group portrait', 1);




INSERT INTO  Users(UserID, Password, Name, Email) VALUES
(1, 'password1', 'Alice Johnson', 'alice@mail.com'),
(2, 'password2', 'Bob Smith', 'bob@mail.com'),
(3, 'password3', 'Charlie Davis', 'charlie@mail.com'),
(4, 'password4', 'Diana Brown', 'diana@mail.com'),
(5, 'password5', 'Eve Wilson', 'eve@mail.com'),
(6, 'password6', 'Frank Taylor', 'frank@mail.com'),
(7, 'password7', 'Grace Lee', 'grace@mail.com'),
(8, 'password8', 'Hank Miller', 'hank@mail.com'),
(9, 'password9', 'Ivy Adams', 'ivy@mail.com'),
(10, 'password10', 'Jack White', 'jack@mail.com'),
(11, 'password11', 'Kathy Green', 'kathy@mail.com'),
(12, 'password12', 'Liam Clark', 'liam@mail.com'),
(13, 'password13', 'Mia Young', 'mia@mail.com'),
(14, 'password14', 'Noah King', 'noah@mail.com'),
(15, 'password15', 'Olivia Scott', 'olivia@mail.com'),
(16, 'password16', 'Paul Harris', 'paul@mail.com'),
(17, 'password17', 'Quinn Evans', 'quinn@mail.com'),
(18, 'password18', 'Ruby Baker', 'ruby@mail.com'),
(19, 'password19', 'Steve Perez', 'steve@mail.com'),
(20, 'password20', 'Tina Sanchez', 'tina@mail.com');

INSERT INTO Ownership (RecordID,UserID, ArtworkID, Price, OwnershipDate) VALUES
(1, 1, 1, 500000, '2015-05-10'),
(2, 1, 2, 750000, '2016-01-15'),
(3, 2, 3, 1500000, '2017-03-20'),
(4, 2, 4, 2000000, '2018-01-25'),
(5, 3, 5, 1200000, '2019-07-30'),
(6, 3, 6, 800000, '2020-02-14'),
(7, 4, 7, 250000, '2021-04-18'),
(8, 4, 8, 1800000, '2021-11-05'),
(9, 5, 9, 450000, '2022-01-10'),
(10, 5, 10, 300000, '2022-06-20'),
(11, 6, 11, 900000, '2023-03-12'),
(12, 6, 12, 650000, '2023-05-15'),
(13, 7, 13, 500000, '2023-07-30'),
(14, 7, 14, 1000000, '2023-09-10'),
(15, 8, 15, 700000, '2023-10-22'),
(16, 8, 16, 400000, '2023-11-01'),
(17, 9, 17, 200000, '2023-11-15'),
(18, 9, 18, 950000, '2023-12-01'),
(19, 10, 19, 1100000, '2023-12-15'),
(20, 10, 20, 850000, '2023-12-20'),
(21, 1, 21, 600000, '2024-01-10'),
(22, 2, 22, 750000, '2024-02-15'),
(23, 3, 23, 1350000, '2024-03-10'),
(24, 4, 24, 250000, '2024-04-18'),
(25, 5, 25, 1800000, '2024-05-20'),
(26, 6, 26, 430000, '2024-06-14'),
(27, 7, 27, 780000, '2024-07-22'),
(28, 8, 28, 220000, '2024-08-05'),
(29, 9, 29, 980000, '2024-09-15'),
(30, 10, 30, 620000, '2024-10-20');





INSERT INTO Galleries (GalleryID, Password, Name, Location, ContactInfo) VALUES
(1, 'gallery1pass', 'Modern Art Gallery', 'New York', 'contact1@mail.com'),
(2, 'gallery2pass', 'Impressionist Center', 'Paris', 'contact2@mail.com'),
(3, 'gallery3pass', 'Surrealism Hall', 'Madrid', 'contact3@mail.com'),
(4, 'gallery4pass', 'The Renaissance Wing', 'Florence', 'contact4@mail.com'),
(5, 'gallery5pass', 'Abstract Expressions', 'Berlin', 'contact5@mail.com'),
(6, 'gallery6pass', 'Pop Art Pavilion', 'London', 'contact6@mail.com'),
(7, 'gallery7pass', 'Cubist Creations', 'Barcelona', 'contact7@mail.com'),
(8, 'gallery8pass', 'Sculpture Studio', 'Rome', 'contact8@mail.com'),
(9, 'gallery9pass', 'Eastern Aesthetics', 'Tokyo', 'contact9@mail.com'),
(10, 'gallery10pass', 'Classical Portraits', 'Vienna', 'contact10@mail.com');




INSERT INTO Exhibitions (ExhibitionID, Name, StartDate, EndDate, GalleryID, ArtworkID) VALUES
(1, 'Dreams in Color', '2024-01-01', '2024-03-01', 1, 1),
(2, 'The Surreal Mind', '2024-02-01', '2024-04-01', 1, 2),
(3, 'Timeless Portraits', '2024-03-01', '2024-05-01', 2, 3),
(4, 'Brushstrokes of History', '2024-04-01', '2024-06-01', 2, 4),
(5, 'War and Peace', '2024-05-01', '2024-07-01', 3, 5),
(6, 'Nature’s Palette', '2024-06-01', '2024-08-01', 3, 6),
(7, 'Sculpted Emotions', '2024-07-01', '2024-09-01', 4, 7),
(8, 'Visions of the Future', '2024-08-01', '2024-10-01', 4, 8),
(9, 'Stories of the East', '2024-09-01', '2024-11-01', 5, 9),
(10, 'Symphony of Shapes', '2024-10-01', '2024-12-01', 5, 10),
(11, 'Impressionist Seasons', '2024-11-01', '2025-01-01', 6, 11),
(12, 'Modernist Revolution', '2024-12-01', '2025-02-01', 6, 12),
(13, 'Golden Age Masterpieces', '2025-01-01', '2025-03-01', 7, 13),
(14, 'Rebel Artists', '2025-02-01', '2025-04-01', 7, 14),
(15, 'Whispers of the North', '2025-03-01', '2025-05-01', 8, 15),
(16, 'Traditions Reimagined', '2025-04-01', '2025-06-01', 8, 16),
(17, 'Epic Narratives', '2025-05-01', '2025-07-01', 9, 17),
(18, 'Calligraphy in Motion', '2025-06-01', '2025-08-01', 9, 18),
(19, 'Dreamtime Myths', '2025-07-01', '2025-09-01', 10, 19),
(20, 'South American Wonders', '2025-08-01', '2025-10-01', 10, 20),
(21, 'Impressionist Icons', '2024-01-15', '2024-03-15', 1, 21),
(22, 'Cubist Masters', '2024-03-20', '2024-05-20', 2, 22),
(23, 'Abstract Visions', '2024-05-25', '2024-07-25', 3, 23),
(24, 'Baroque Brilliance', '2024-07-30', '2024-09-30', 4, 24),
(25, 'Classical Journeys', '2024-10-05', '2024-12-05', 5, 25),
(26, 'Art Nouveau Dreams', '2024-12-10', '2025-02-10', 6, 26),
(27, 'Renaissance Wonders', '2025-02-15', '2025-04-15', 7, 27),
(28, 'Romantic Era Showcase', '2025-04-20', '2025-06-20', 8, 28),
(29, 'Cultural Heritage', '2025-06-25', '2025-08-25', 9, 29),
(30, 'Modern Marvels', '2025-08-30', '2025-10-30', 10, 30);


INSERT INTO Reviews (ReviewID, UserID, ArtworkID, Comment, Rating) VALUES
(1, 1, 1, 'A surreal masterpiece!', 5),
(2, 2, 1, 'Thought-provoking and unique.', 4),
(3, 3, 2, 'The night sky comes alive.', 5),
(4, 4, 2, 'Vivid and enchanting.', 4),
(5, 5, 3, 'A timeless depiction of unity.', 5),
(6, 6, 3, 'Historical and emotional.', 5),
(7, 7, 4, 'An enigmatic beauty.', 5),
(8, 8, 4, 'The smile is captivating.', 4),
(9, 9, 5, 'A powerful anti-war message.', 5),
(10, 10, 5, 'Emotionally intense.', 4),
(11, 11, 6, 'Calming and serene.', 5),
(12, 12, 6, 'Nature at its finest.', 5),
(13, 13, 7, 'Hauntingly beautiful.', 5),
(14, 14, 7, 'The anguish is palpable.', 4),
(15, 15, 8, 'Iconic and inspirational.', 5),
(16, 16, 8, 'A spiritual marvel.', 4),
(17, 17, 9, 'Simple yet profound.', 5),
(18, 18, 9, 'A charming portrait.', 4),
(19, 19, 10, 'Dynamic and dramatic.', 5),
(20, 20, 10, 'Bold and striking.', 4),
(21, 1, 11, 'Captures the essence of pop art.', 5),
(22, 2, 11, 'Playful and clever.', 4),
(23, 3, 12, 'A deeply personal work.', 5),
(24, 4, 12, 'Full of raw emotion.', 4),
(25, 5, 13, 'Bright and cheerful.', 5),
(26, 6, 13, 'Pure sunshine in a frame.', 5),
(27, 7, 14, 'Intriguing and geometric.', 5),
(28, 8, 14, 'A symphony of shapes.', 4),
(29, 9, 15, 'Energetic and modern.', 5),
(30, 10, 15, 'A vibrant urban landscape.', 4);



INSERT INTO VerificationRequest (RequestID, UserID, ArtworkID, RequestDate, VerificationStatus) VALUES
(1, 1, 1, '2023-10-01', 'Pending'),
(2, 2, 2, '2023-10-05', 'Approved'),
(3, 3, 3, '2023-10-10', 'Rejected'),
(4, 4, 4, '2023-10-15', 'Approved'),
(5, 5, 5, '2023-10-20', 'Pending'),
(6, 6, 6, '2023-10-25', 'Rejected'),
(7, 7, 7, '2023-10-30', 'Approved'),
(8, 8, 8, '2023-11-01', 'Pending'),
(9, 9, 9, '2023-11-05', 'Approved'),
(10, 10, 10, '2023-11-10', 'Rejected'),
(11, 11, 11, '2023-11-15', 'Pending'),
(12, 12, 12, '2023-11-20', 'Approved'),
(13, 13, 13, '2023-11-25', 'Rejected'),
(14, 14, 14, '2023-11-30', 'Approved'),
(15, 15, 15, '2023-12-01', 'Pending'),
(16, 16, 16, '2023-12-05', 'Approved'),
(17, 17, 17, '2023-12-10', 'Rejected'),
(18, 18, 18, '2023-12-15', 'Approved'),
(19, 19, 19, '2023-12-20', 'Pending'),
(20, 20, 20, '2023-12-25', 'Approved');




INSERT INTO AuctionHouse (AuctionID, GalleryID, ArtworkID, Name, StartingPrice) VALUES
(1, 1, 1, 'Winter Wonders Auction', 500000),
(2, 2, 2, 'Spring Delights Auction', 700000),
(3, 3, 3, 'Summer Showcase Auction', 1500000),
(4, 4, 4, 'Autumn Elegance Auction', 2000000),
(5, 5, 5, 'Holiday Specials Auction', 1200000),
(6, 6, 6, 'Collector’s Gems Auction', 800000),
(7, 7, 7, 'Art World’s Finest Auction', 250000),
(8, 8, 8, 'Masterpieces of Time Auction', 1800000),
(9, 9, 9, 'Abstract Icons Auction', 450000),
(10, 10, 10, 'Pop Art Parade Auction', 300000),
(11, 1, 11, 'Sculpture Spotlight Auction', 900000),
(12, 2, 12, 'Cultural Heritage Auction', 650000),
(13, 3, 13, 'Dutch Masters Auction', 500000),
(14, 4, 14, 'Impressionist Marvels Auction', 1000000),
(15, 5, 15, 'Surreal Wonders Auction', 700000),
(16, 6, 16, 'Expressionist Highlights Auction', 400000),
(17, 7, 17, 'Renaissance Reverie Auction', 200000),
(18, 8, 18, 'Modernist Revolution Auction', 950000),
(19, 9, 19, 'Contemporary Visions Auction', 1100000),
(20, 10, 20, 'Epic Narratives Auction', 850000);