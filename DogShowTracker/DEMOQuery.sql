
BEGIN TRAN
INSERT INTO Breeds
	(Breed, [Classification], PrimaryCoatColour, SecondaryCoatColour)
	Values
	('Demo', 5, 5, 5);
SELECT * FROM Breeds;
ROLLBACK