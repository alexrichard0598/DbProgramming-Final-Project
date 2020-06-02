USE DogShowDb;


SELECT	BreedID, Breed, Class, 
		PrimaryColour.Colour AS PrimaryCoatColour, 
		COALESCE(SecondaryColour.Colour, 'None') AS SecondaryCoatColour FROM Breeds
	LEFT JOIN Colours AS PrimaryColour
		ON PrimaryCoatColour = PrimaryColour.ColourID
	LEFT JOIN Colours AS SecondaryColour
		ON SecondaryColour.ColourID = SecondaryCoatColour
	LEFT JOIN Classes
		ON [Classification] = ClassID;



SELECT ClassID, Class FROM Classes;


SELECT ColourID, Colour FROM Colours;




SELECT Owners.FirstName + ' ' + COALESCE(Owners.MiddleName + ' ', '') + Owners.LastName AS OwnerName, 
		Dogs.[Name], StartOfOwnership, EndOfOwnership FROM DogOwnership
	LEFT JOIN Owners
		ON DogOwnership.OwnerID = Owners.OwnerID
	LEFT JOIN Dogs
		ON Dogs.DogID = DogOwnership.DogID;




SELECT	[Name], (CASE Sex WHEN 1 THEN 'Male' ELSE 'Female' END) AS Sex, 
		[Weight], Height, DOB, DateOfRetirement, Retired, DateOfChampionship, 
		Champion, PermanentlyDisqualified, Breeds.Breed FROM Dogs
	LEFT JOIN Breeds
		ON Dogs.Breed = BreedID;

SELECT DogShowID, [Name], StartDate, EndDate, NumDogs FROM DogShows;


SELECT OwnerID, FirstName, MiddleName, LastName, DOB, DateOfRetirement, Retired FROM Owners;

SELECT	Dogs.[Name] AS DogName, DogShows.[Name] AS DogShowName,  
		COALESCE(CAST([Rank] AS VARCHAR), '-') + '/' + CAST(DogShows.NumDogs AS VARCHAR) AS Placed, 
		(CASE Disqualified WHEN 1 THEN 'Yes' ELSE 'No' END) AS Disqualified FROM DogShowDetails
	LEFT JOIN Dogs
		ON Dogs.DogID = DogShowDetails.DogID
	LEFT JOIN DogShows
		ON DogShowDetails.DogShowID = DogShows.DogShowID
	ORDER BY DogShowDetails.DogShowID, COALESCE([Rank], 999);