USE MASTER;
GO

IF DB_ID('DogShowDb') IS NOT NULL
BEGIN
	DROP DATABASE DogShowDb;
END

CREATE DATABASE DogShowDb;
USE DogShowDb;
GO

CREATE TABLE Classes
(
	ClassID INT PRIMARY KEY IDENTITY,
	Class VARCHAR(24) NOT NULL
);
GO

INSERT INTO Classes
	(Class)
	VALUES
	('Herding'),
	('Hound'),
	('Toy'),
	('Non-Sporting'),
	('Sporting'),
	('Terrier'),
	('Working'),
	('Misc.');

GO

CREATE TABLE Colours
(
	ColourID INT PRIMARY KEY IDENTITY,
	Colour VARCHAR(24) NOT NULL
);
GO

INSERT INTO Colours
	(Colour)
	VALUES
	('Black'),
	('Chocolate'),
	('Apricot'),
	('Tan'),
	('Golden'),
	('Brindle'),
	('White'),
	('Gold'),
	('Blue Merle'),
	('Rust'),
	('Blenheim'),
	('Silver'),
	('Black & Rust'),
	('Liver'),
	('Blue'),
	('Black & Tan'),
	('Brown'),
	('Fawn'),
	('Sable');
GO

CREATE TABLE Breeds
(
	BreedID INT PRIMARY KEY IDENTITY,
	Breed VARCHAR(32) NOT NULL,
	[Classification] INT FOREIGN KEY REFERENCES Classes(ClassID) NOT NULL,
	PrimaryCoatColour INT FOREIGN KEY REFERENCES Colours(ColourID) NOT NULL,
	SecondaryCoatColour INT FOREIGN KEY REFERENCES Colours(ColourID) NULL
);
GO

INSERT INTO Breeds
	(Breed, PrimaryCoatColour, SecondaryCoatColour, [Classification])
	VALUES
	('Labrador Retriever',2,NULL,5),
	('German Shepherd',1,4,1),
	('Golden Retriever',5,NULL,5),
	('French Bulldog',6,7,4),
	('Beagle',1,4,2),
	('Poodle',3,NULL,4),
	('Rottweiler',1,4,7),
	('German Shorthaired Pointer',1,7,5),
	('Yorksire 6',1,8,3),
	('Boxer',6,7,7),
	('Dachshund',1,4,2),
	('Pembroke Welsh Corgi',4,7,1),
	('Siberian Husky',1,7,7),
	('Australian Shepherd',9,7,1),
	('Great Dane',4,1,7),
	('Doberman Pinschers',10,1,7),
	('Cavalier King Charles Spaniel',11,7,3),
	('Miniature Schnauzer',1,12,6),
	('Shih Tzu',1,7,3),
	('Boston 6',1,7,4),
	('Bernese Mountain Dog',13,7,7),
	('Pomeranian',4,7,3),
	('Havanese',1,7,3),
	('Shetland Sheepdog',4,7,1),
	('Brittany',14,7,5),
	('English Springer Spaniel',1,7,5),
	('Pug',4,1,3),
	('Mastiff',4,1,7),
	('Cocker Spaniel',7,1,5),
	('Vizslas',5,10,5),
	('Cane Corso',1,7,7),
	('Chihuahua',4,7,3),
	('Miniature American Shepherd',9,7,1),
	('Border Collie',1,7,1),
	('Weimarnaer',15,NULL,5),
	('Maltese',7,NULL,3),
	('Collie',16,7,1),
	('Basset 2',17,7,1),
	('Newfoundland',1,NULL,7),
	('Rhodesian Ridgeback',4,1,2),
	('West Highland White 6',7,NULL,6),
	('Belgian Malinois',18,19,1),
	('Shiba Inu',4,7,4),
	('Chesapeake Bay Retriever',17,NULL,5),
	('Bichon Frise',7,NULL,4),
	('Akita Inu',17,7,7),
	('St. Bernard',17,7,7),
	('Blood2',17,1,2),
	('Portuguese Water Dog',1,7,7);
GO

CREATE TABLE Dogs
(
	DogID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Sex BIT NOT NULL,
	[Weight] DECIMAL(4,1) NOT NULL,
	Height DECIMAL(4,1) NOT NULL,
	DOB DATE NOT NULL,
	DateOfRetirement DATE NULL,
	Retired BIT NOT NULL,
	DateOfChampionship DATE NULL,
	Champion BIT NOT NULL,
	DateOfDisqualification DATE NULL,
	PermanentlyDisqualified BIT NOT NULL,
	Breed INT FOREIGN KEY REFERENCES Breeds(BreedID),
	CONSTRAINT CK_DOGS_RetiredDate_RetiredMustBeTrue CHECK(NOT(Retired = 0 AND DateOfRetirement IS NOT NULL)),
	CONSTRAINT CK_DOGS_ChampionDate_ChampionMustBeTrue CHECK(NOT(Champion = 0 AND DateOfChampionship IS NOT NULL)),
	CONSTRAINT CK_DOGS_DisqualDate_MustBeDisqual CHECK(NOT(PermanentlyDisqualified = 0 AND DateOfDisqualification IS NOT NULL))
);
GO

INSERT INTO Dogs
	([Name],Sex,[Weight],Height,DOB,DateOfRetirement,Retired,DateOfChampionship,Champion,DateOfDisqualification,PermanentlyDisqualified,Breed)
	VALUES
	('Caesar',1,2.4,16.5,'2009-09-16','2013-08-29',1,NULL,0,NULL,0,32),
	('Dizzy',1,10.0,33.7,'2007-07-10','2010-11-11',1,NULL,0,NULL,0,5),
	('Seal',0,26.6,55.0,'2007-09-12','2011-08-23',1,'2010-07-22',1,NULL,0,2),
	('Cinder',1,35.7,63.7,'2017-04-17',NULL,0,NULL,0,NULL,0,1),
	('ChoMein',1,30.7,59.1,'2019-01-08',NULL,0,NULL,0,NULL,0,6),
	('Sarasota',1,75.2,92.4,'2003-02-24',NULL,0,NULL,0,'2011-07-22',1,15),
	('Felix',1,26.6,55.0,'2002-05-10','2011-04-25',1,NULL,0,NULL,0,13),
	('Havoc',0,25.7,54.0,'2014-08-31',NULL,0,NULL,0,NULL,0,3),
	('Kisses',1,2.8,17.8,'2012-04-24','2015-11-02',1,NULL,0,NULL,0,9),
	('Vaquero',0,20.8,48.6,'2005-03-04','2012-03-26',1,NULL,0,NULL,0,14),
	('Mickey',0,40.4,67.8,'2002-07-13',NULL,0,'2008-04-15',1,'2012-08-18',1,7),
	('Nibbles',1,42.5,69.5,'2015-05-20',NULL,0,NULL,0,NULL,0,16),
	('Sniffles',0,22.1,50.1,'2013-08-18',NULL,0,NULL,0,NULL,0,8),
	('Bianco',1,89.0,100.6,'2011-04-16',NULL,0,'2019-09-07',1,NULL,0,28),
	('Dino',0,15.4,41.8,'2003-09-28','2006-08-08',1,'2005-04-26',1,NULL,0,25),
	('Abby',0,61.7,83.7,'2008-04-15','2015-06-03',1,NULL,0,NULL,0,47),
	('Attila',1,12.0,36.9,'2018-08-31',NULL,0,NULL,0,'2019-12-05',1,4),
	('Guru',1,34.7,62.8,'2003-05-31','2012-02-27',1,NULL,0,NULL,0,10),
	('Genius',0,8.5,31.1,'2003-04-18','2013-10-08',1,NULL,0,NULL,0,11),
	('Loruss',0,6.1,26.3,'2004-04-18','2008-11-06',1,NULL,0,NULL,0,17),
	('Buddy',1,6.5,27.2,'2016-09-15',NULL,0,NULL,0,NULL,0,20),
	('Wilbur',1,45.0,71.5,'2012-01-27','2019-02-20',1,'2012-06-17',1,NULL,0,21),
	('Digger',0,61.0,83.3,'2012-02-19',NULL,0,NULL,0,NULL,0,47),
	('Slugger',1,3.9,21.1,'2000-11-22','2007-06-26',1,NULL,0,NULL,0,19),
	('Fleabag',0,2.9,18.2,'2010-07-14',NULL,0,NULL,0,NULL,0,36),
	('Verona',0,21.5,49.4,'2011-12-21','2016-10-24',1,NULL,0,NULL,0,49),
	('Snowbunny',0,40.2,67.6,'2018-06-04',NULL,0,NULL,0,NULL,0,48),
	('Sangria',0,24.8,53.1,'2017-09-16',NULL,0,NULL,0,NULL,0,2),
	('Ralph',1,10.1,33.9,'2013-07-10',NULL,0,NULL,0,NULL,0,43),
	('Caper',1,10.6,34.7,'2003-10-11','2008-04-22',1,NULL,0,NULL,0,43),
	('Eggo',0,27.8,56.2,'2000-11-11','2009-03-29',1,NULL,0,NULL,0,1),
	('Alpha',1,56.1,79.8,'2013-10-22','2017-10-04',1,NULL,0,NULL,0,7),
	('Bengal',0,5.4,24.8,'2011-04-03',NULL,0,NULL,0,NULL,0,23),
	('Rufus',0,12.6,37.8,'2017-06-07',NULL,0,NULL,0,NULL,0,12),
	('Pooh',0,30.2,58.6,'2010-11-24',NULL,0,NULL,0,NULL,0,46),
	('Piper',0,7.5,29.2,'2005-05-18','2013-06-08',1,'2011-02-25',1,NULL,0,18),
	('Magic',1,22.2,50.2,'2009-07-29','2014-07-22',1,NULL,0,NULL,0,26),
	('Petunia',1,35.7,63.7,'2000-02-25','2004-09-25',1,NULL,0,NULL,0,46),
	('Guffaw',1,31.6,59.9,'2009-12-12',NULL,0,NULL,0,'2010-07-07',1,44),
	('Thomas',1,7.4,29.0,'2009-03-03','2013-09-12',1,NULL,0,NULL,0,45),
	('Tar',0,10.0,33.7,'2001-03-01','2006-12-29',1,NULL,0,NULL,0,29),
	('Cruiser',1,26.5,54.9,'2010-09-11','2014-02-13',1,NULL,0,NULL,0,30),
	('Hammer',0,10.3,34.2,'2008-03-01','2012-05-21',1,NULL,0,NULL,0,33),
	('Paco',1,12.0,36.9,'2009-11-07','2014-04-08',1,NULL,0,NULL,0,31),
	('Melvin',1,61.6,83.7,'2009-09-30','2013-11-08',1,'2011-02-10',1,NULL,0,39),
	('Sasquatch',1,101.0,107.1,'2010-06-06','2019-01-28',1,NULL,0,NULL,0,28),
	('Eskimo',1,7.0,28.2,'2000-06-27',NULL,0,NULL,0,'2010-03-29',1,27),
	('Bug',0,9.7,33.2,'2004-04-11','2008-01-28',1,NULL,0,NULL,0,11),
	('Coon',0,22.6,50.7,'2009-05-31','2014-06-20',1,NULL,0,NULL,0,42),
	('Salty',0,5.4,24.8,'2017-03-22',NULL,0,NULL,0,NULL,0,20),
	('Arty',0,7.3,28.8,'2003-12-24','2012-07-22',1,NULL,0,NULL,0,24),
	('Sinclair',1,11.0,35.4,'2014-09-27',NULL,0,NULL,0,NULL,0,4),
	('Wink',0,25.1,53.4,'2009-08-14','2018-09-22',1,'2018-09-05',1,NULL,0,38),
	('Doglet',0,69.8,89.1,'2016-11-02',NULL,0,NULL,0,NULL,0,28),
	('Mayhem',0,3.5,19.9,'2010-06-02',NULL,0,NULL,0,'2012-02-09',1,9),
	('Fauna',1,19.4,47.0,'2016-06-27',NULL,0,NULL,0,NULL,0,34),
	('Hachiko',1,35.0,63.1,'2006-04-03','2009-01-09',1,NULL,0,NULL,0,35),
	('Crystal',1,19.2,46.7,'2007-05-19','2015-04-26',1,NULL,0,NULL,0,49),
	('Nomad',1,2.0,15.1,'2013-10-11',NULL,0,'2017-03-10',1,NULL,0,22),
	('Poindexter',0,7.6,29.4,'2002-09-11','2009-07-07',1,NULL,0,NULL,0,41),
	('Wacky',1,84.2,97.8,'2008-12-13','2018-05-20',1,NULL,0,NULL,0,28),
	('Snow',0,40.5,67.8,'2017-03-23',NULL,0,NULL,0,NULL,0,21),
	('Genghis',0,46.3,72.5,'2013-03-29',NULL,0,NULL,0,NULL,0,39),
	('Tsunami',0,2.5,16.9,'2019-08-26',NULL,0,NULL,0,NULL,0,36),
	('Badger',0,25.6,53.9,'2000-01-04',NULL,0,NULL,0,'2010-07-22',1,37),
	('Serenade',0,8.3,30.7,'2007-05-12','2008-03-01',1,NULL,0,NULL,0,43),
	('Lulu',1,81.3,96.1,'2000-08-02','2009-05-09',1,NULL,0,NULL,0,47),
	('Boots',0,25.0,53.3,'2011-07-21','2019-05-21',1,NULL,0,NULL,0,38),
	('Dozer',0,33.0,61.2,'2003-03-19','2008-06-29',1,NULL,0,NULL,0,40),
	('Bazooka',1,8.5,31.1,'2003-11-01',NULL,0,NULL,0,'2013-11-21',1,24),
	('Dancer',0,36.0,64.0,'2007-06-18','2017-04-10',1,NULL,0,NULL,0,21),
	('Sunrise',0,58.6,81.6,'2015-12-21',NULL,0,'2017-10-14',1,NULL,0,47),
	('SixToes',0,12.2,37.2,'2012-06-01','2017-08-04',1,NULL,0,NULL,0,33),
	('Nutmeg',1,76.6,93.3,'2002-12-29','2009-03-06',1,NULL,0,NULL,0,47),
	('Ace',0,22.1,50.1,'2003-03-23','2005-07-18',1,NULL,0,NULL,0,14),
	('SweetPea',0,23.8,52.0,'2002-09-28','2010-07-05',1,NULL,0,NULL,0,42),
	('Machete',0,1.5,13.1,'2011-10-09','2020-04-30',1,NULL,0,NULL,0,32),
	('Rot',1,23.8,52.0,'2000-05-26','2011-08-17',1,NULL,0,NULL,0,26),
	('Dreamer',1,34.7,62.8,'2003-02-11','2004-12-18',1,NULL,0,NULL,0,44),
	('Monty',0,1.7,13.9,'2007-05-03','2011-02-15',1,NULL,0,NULL,0,22);
GO

CREATE TABLE Owners
(
	OwnerID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50) NULL,
	LastName VARCHAR(50) NOT NULL,
	DOB DATE NOT NULL,
	DateOfRetirement DATE NULL,
	Retired BIT NOT NULL,
	CONSTRAINT CK_OWNERS_RetiredDate_MustBeRetired CHECK(NOT(Retired = 0 AND DateOfRetirement IS NOT NULL))
)

INSERT INTO Owners
	([FirstName], [MiddleName], [LastName], [DOB], [Retired], [DateOfRetirement])
	VALUES
	('Sam','Kara','Yates','1978-10-16',0,NULL),
	('Brandi','Lora','Cox','1979-08-05',0,NULL),
	('June','Janice','Sharp','1990-08-24',0,NULL),
	('Billie','Ian','Caldwell','1973-12-03',1,'1990-06-23'),
	('Katherine','Winifred','Garcia','1987-10-27',0,NULL),
	('Alejandro',NULL,'Bishop','1976-11-28',0,NULL),
	('Douglas',NULL,'Quinn','1975-04-22',0,NULL),
	('Cora','Joe','Harrington','1981-12-21',0,NULL),
	('Jorge','Guy','Lewis','1998-07-22',0,NULL),
	('Grady','Joel','Reed','1996-10-02',0,NULL),
	('Andrew','Jay','Ramsey','1984-01-13',0,NULL),
	('Sherman',NULL,'Underwood','1979-05-11',0,NULL),
	('Victoria','Ashley','Daniels','1978-11-25',0,NULL),
	('Dewey','Laurence','Cobb','1983-11-11',1,'1993-08-01'),
	('Horace','Ed','Robbins','1984-06-11',0,NULL),
	('Neil',NULL,'Wells','1976-07-09',0,NULL),
	('Malcolm','Tracey','Hamilton','1988-07-13',0,NULL),
	('Lena','Cornelius','Webb','1995-08-15',0,NULL),
	('Ed','Danny','Nunez','1993-09-16',1,'1994-10-07'),
	('Kristin','Black','Garner','1996-06-22',0,NULL),
	('Ida','Debra','Glover','1973-09-02',0,NULL),
	('Melanie',NULL,'Dennis','1988-01-22',0,NULL),
	('Andy','Bynthia','Willis','1977-04-13',1,'1989-08-22'),
	('Lorenzo','Jeremiah','Scott','1999-03-22',0,NULL),
	('Angelica','Desiree','Carson','2000-07-24',0,NULL),
	('Angelina','Leona','Shelton','1974-05-24',0,NULL),
	('Jim','Darrel','Richardson','1977-08-07',0,NULL),
	('Melvin','Essie','Larson','1981-05-09',0,NULL),
	('Elsa','Nathan','Gibson','1972-11-11',0,NULL),
	('Michael','Roy','Armstrong','1979-05-20',0,NULL),
	('Shelia','Lela','Doyle','1982-02-09',0,NULL),
	('Paulette','Carla','Patterson','1985-09-20',0,NULL),
	('Faith','Kelvin','Rodriguez','1978-09-24',0,NULL),
	('Shawn','Jamie','Moss','1972-03-13',1,'1994-12-18'),
	('Wayne','Janet','Meyer','1989-01-22',0,NULL),
	('Jodi','Tasha','Saunders','1985-06-19',0,NULL),
	('Lori','Denise','Fox','1973-09-13',0,NULL),
	('Bill','Victor','Castro','1981-06-18',0,NULL),
	('Wesley','Juanita','Porter','1984-11-25',0,NULL),
	('Terry','Bryant','Hudson','1982-08-13',0,NULL),
	('Shannon','Ella','Peters','1987-12-20',0,NULL),
	('Darlene','May','Pratt','1984-04-30',0,NULL),
	('Jan',NULL,'Johnson','2000-08-05',0,NULL),
	('Charlene',NULL,'Bailey','1998-12-21',0,NULL),
	('Patrick','Bradford','Coleman','1989-12-17',0,NULL),
	('Gerard','Katrina','Reyes','1975-05-21',0,NULL),
	('Loren','Harriet','Graves','1984-04-13',0,NULL),
	('Pam','Christy','Schneider','1990-04-24',0,NULL),
	('Cesar','Adrian','Lawson','1990-12-09',0,NULL),
	('Lucas','Antoinette','Holt','1990-07-31',0,NULL),
	('Leigh','Fred','Pearson','1975-06-08',0,NULL),
	('Roosevelt','Jaime','Simpson','1981-11-02',0,NULL),
	('Carole','Clarence','Cooper','1983-05-02',1,'1989-11-30'),
	('Terri','Norman','Horton','1981-12-30',0,NULL),
	('Darla','Albert','Terry','1970-02-18',0,NULL),
	('Elaine','Janie','Park','1996-12-24',0,NULL),
	('Lester',NULL,'Maxwell','1993-06-28',0,NULL),
	('Gustavo',NULL,'Miller','1991-10-04',1,'1993-12-25'),
	('Melinda',NULL,'Becker','1998-11-25',0,NULL),
	('Winifred',NULL,'Hunter','1980-06-23',1,'1992-06-25'),
	('Dustin','Sonya','Chavez','1994-07-09',0,NULL),
	('Viola','Flora','Stewart','1989-10-19',0,NULL),
	('Reginald','Barry','Berry','1984-05-06',0,NULL),
	('Ron','Ken','Allen','1991-11-01',0,NULL),
	('Anne','Ruby','Thompson','1975-11-07',0,NULL),
	('Katrina','Robin','Fisher','1992-09-10',0,NULL),
	('Tasha','Ernestine','Philips','1988-03-10',1,'1997-03-11'),
	('Laurence','Alvin','Blair','1991-12-10',0,NULL),
	('Misty','Terence','Owens','1991-05-31',0,NULL),
	('Edmund','Karen','Francis','1993-10-29',0,NULL),
	('Jeanette','Ricky','Joseph','1994-03-02',0,NULL),
	('Lindsey','Teri','Warner','1992-07-09',0,NULL),
	('Wallace','Nash','Wood','1996-11-12',1,'2001-09-22'),
	('Bryan','Edgar','Ramirez','1994-10-28',0,NULL),
	('Mildred','Glenn','Griffith','1980-01-09',0,NULL),
	('Priscilla','Leigh','Mullins','1990-06-02',0,NULL),
	('Saul','Kimberly','Mc''Kinney','1965-10-25',0,NULL),
	('Eleanor','Lloyd','Harrison','1995-02-16',0,NULL),
	('Louis','Sylvester','Phelps','1997-08-04',0,NULL),
	('Ollie','Maria','Stevenson','1967-02-09',0,NULL),
	('Otis','Ross','Page','1990-12-18',0,NULL),
	('Geraldine','Roger','Morris','1967-06-20',0,NULL),
	('Bobby','Phyllis','Smith','1990-12-04',0,NULL),
	('Sylvia','Ricia','Baldwin','1969-08-05',0,NULL),
	('Pauline',NULL,'Newton','1998-02-05',0,NULL),
	('Alexandra',NULL,'Bridges','1965-06-29',0,NULL),
	('Jerald','Sean','Drake','1990-10-16',0,NULL),
	('Luther',NULL,'Shaw','1966-10-30',1,'1990-08-10'),
	('Jan','Randy','Mason','1969-08-22',1,'1996-04-17'),
	('Jamie',NULL,'Dunn','1998-12-09',0,NULL),
	('Freed','Cheryl','Munoz','1969-02-22',1,'1987-06-07'),
	('Jordan','Emillio','Welch','2000-07-20',0,NULL),
	('Kristy','Aubrey','Wallace','1999-05-23',0,NULL),
	('Kenneth','Nash','Ward','1969-09-18',0,NULL),
	('Guillermo','Bert','Figueroa','2000-08-07',0,NULL),
	('Jeffrey','Meghan','Dean','1970-05-27',0,NULL),
	('Cameron','Estelle','Chandler','1991-11-13',0,NULL),
	('Lora','Porter','Watson','2000-01-18',0,NULL),
	('Blake','Potter','Marshall','2000-04-25',0,NULL);

CREATE TABLE DogShows
(
	DogShowID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(150) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	NumDogsFinished INT NOT NULL,
	CONSTRAINT CK_EndDate_After_StartDate CHECK(EndDate>StartDate)
);

INSERT INTO DogShows
	([Name],[StartDate],[EndDate],[NumDogsFinished])
	VALUES
	('American Kennel Club','2003-02-17','2003-02-21',28),
	('Canadian Kennel Club','2005-02-10','2005-02-16',15),
	('New Zealand Kennel Club','2000-08-17','2000-08-23',14),
	('World Canine Organization','2005-07-08','2005-07-14',18),
	('Canadian Kennel Club','2003-02-18','2003-02-24',12),
	('Canadian Kennel Club','2008-07-15','2008-07-19',27),
	('World Canine Organization','2006-01-31','2006-02-04',13),
	('United Kennel Club','2006-06-28','2006-07-01',28),
	('Australian National Kennel Coucil','2013-12-02','2013-12-05',28),
	('American Kennel Club','2006-01-25','2006-01-31',26),
	('The Kennel Club','2000-03-06','2000-03-11',20),
	('American Kennel Club','2008-12-12','2008-12-18',18),
	('New Zealand Kennel Club','2006-03-04','2006-03-08',27),
	('World Canine Organization','2016-09-23','2016-09-29',12),
	('Australian National Kennel Coucil','2011-02-03','2011-02-09',29),
	('American Kennel Club','2010-02-09','2010-02-14',22),
	('Canadian Kennel Club','2015-11-15','2015-11-18',14),
	('World Canine Organization','2019-06-30','2019-07-04',23),
	('World Canine Organization','2015-10-21','2015-10-24',20),
	('Australian National Kennel Coucil','2014-03-13','2014-03-18',11),
	('The Kennel Club','2005-05-14','2005-05-19',19),
	('Canadian Kennel Club','2001-03-18','2001-03-22',28),
	('American Kennel Club','2012-11-15','2012-11-21',25),
	('The Kennel Club','2019-04-20','2019-04-27',14),
	('New Zealand Kennel Club','2011-12-11','2011-12-17',28),
	('United Kennel Club','2009-01-16','2009-01-21',27),
	('American Kennel Club','2004-02-03','2004-02-07',30),
	('United Kennel Club','2015-05-17','2015-05-24',16),
	('The Kennel Club','2008-12-31','2009-01-04',23);