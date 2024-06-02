-- Création des tables s'il n'existe pas
IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(50) NOT NULL,
        Password NVARCHAR(50) NOT NULL,
        Role NVARCHAR(20) NOT NULL
    );
END

IF OBJECT_ID('dbo.FoodSpecification', 'U') IS NULL
BEGIN
    CREATE TABLE FoodSpecification (
        FoodSpecID INT PRIMARY KEY IDENTITY(1,1),
        UserID INT FOREIGN KEY REFERENCES Users(UserID),
        Specification NVARCHAR(255) NOT NULL
    );
END

IF OBJECT_ID('dbo.MealList', 'U') IS NULL
BEGIN
    CREATE TABLE MealList (
        MealID INT PRIMARY KEY IDENTITY(1,1),
        MealName NVARCHAR(100) NOT NULL,
        Description NVARCHAR(255)
    );
END

IF OBJECT_ID('dbo.OrderedMeal', 'U') IS NULL
BEGIN
    CREATE TABLE OrderedMeal (
        OrderID INT PRIMARY KEY IDENTITY(1,1),
        UserID INT FOREIGN KEY REFERENCES Users(UserID),
        MealID INT FOREIGN KEY REFERENCES MealList(MealID),
        OrderDate DATETIME NOT NULL
    );
END

IF OBJECT_ID('dbo.MealFoodSpecification', 'U') IS NULL
BEGIN
    CREATE TABLE MealFoodSpecification (
        MealID INT FOREIGN KEY REFERENCES MealList(MealID),
        FoodSpecID INT FOREIGN KEY REFERENCES FoodSpecification(FoodSpecID),
        PRIMARY KEY (MealID, FoodSpecID)
    );
END

-- Insertion des utilisateurs
IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'test' AND Role = 'Admin')
BEGIN
    INSERT INTO Users (Username, Password, Role) VALUES ('test', 'test', 'Admin');
END
IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'test1' AND Role = 'Student')
BEGIN
    INSERT INTO Users (Username, Password, Role) VALUES ('test1', 'test1', 'Student');
END
IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'test2' AND Role = 'Staff')
BEGIN
    INSERT INTO Users (Username, Password, Role) VALUES ('test2', 'test2', 'Staff');
END

-- Insertion des spécifications alimentaires
IF NOT EXISTS (SELECT 1 FROM FoodSpecification WHERE UserID = 1 AND Specification = 'Vegetarian')
BEGIN
    INSERT INTO FoodSpecification (UserID, Specification) VALUES (1, 'Vegetarian');
END
IF NOT EXISTS (SELECT 1 FROM FoodSpecification WHERE UserID = 4 AND Specification = 'Gluten-Free')
BEGIN
    INSERT INTO FoodSpecification (UserID, Specification) VALUES (4, 'Gluten-Free');
END
IF NOT EXISTS (SELECT 1 FROM FoodSpecification WHERE UserID = 5 AND Specification = 'Vegan')
BEGIN
    INSERT INTO FoodSpecification (UserID, Specification) VALUES (5, 'Vegan');
END

-- Insertion des repas
IF NOT EXISTS (SELECT 1 FROM MealList WHERE MealName = 'Spaghetti Bolognese')
BEGIN
    INSERT INTO MealList (MealName, Description) VALUES ('Spaghetti Bolognese', 'Pasta with meat sauce');
END
IF NOT EXISTS (SELECT 1 FROM MealList WHERE MealName = 'Vegan Salad')
BEGIN
    INSERT INTO MealList (MealName, Description) VALUES ('Vegan Salad', 'Mixed greens with a variety of vegetables');
END
IF NOT EXISTS (SELECT 1 FROM MealList WHERE MealName = 'Chicken Sandwich')
BEGIN
    INSERT INTO MealList (MealName, Description) VALUES ('Chicken Sandwich', 'Grilled chicken sandwich with lettuce and tomato');
END

-- Récupération des IDs des repas et des spécifications alimentaires pour les insertions conditionnelles
DECLARE @MealID1 INT, @MealID2 INT, @MealID3 INT;
DECLARE @FoodSpecID1 INT, @FoodSpecID2 INT, @FoodSpecID3 INT;

SELECT @MealID1 = MealID FROM MealList WHERE MealName = 'Spaghetti Bolognese';
SELECT @MealID2 = MealID FROM MealList WHERE MealName = 'Vegan Salad';
SELECT @MealID3 = MealID FROM MealList WHERE MealName = 'Chicken Sandwich';

SELECT @FoodSpecID1 = FoodSpecID FROM FoodSpecification WHERE Specification = 'Vegetarian';
SELECT @FoodSpecID2 = FoodSpecID FROM FoodSpecification WHERE Specification = 'Gluten-Free';
SELECT @FoodSpecID3 = FoodSpecID FROM FoodSpecification WHERE Specification = 'Vegan';

-- Insertion des spécifications alimentaires pour les repas
IF NOT EXISTS (SELECT 1 FROM MealFoodSpecification WHERE MealID = @MealID1 AND FoodSpecID = @FoodSpecID1)
BEGIN
    INSERT INTO MealFoodSpecification (MealID, FoodSpecID) VALUES (@MealID1, @FoodSpecID1);
END

IF NOT EXISTS (SELECT 1 FROM MealFoodSpecification WHERE MealID = @MealID2 AND FoodSpecID = @FoodSpecID3)
BEGIN
    INSERT INTO MealFoodSpecification (MealID, FoodSpecID) VALUES (@MealID2, @FoodSpecID3);
END

IF NOT EXISTS (SELECT 1 FROM MealFoodSpecification WHERE MealID = @MealID3 AND FoodSpecID = @FoodSpecID2)
BEGIN
    INSERT INTO MealFoodSpecification (MealID, FoodSpecID) VALUES (@MealID3, @FoodSpecID2);
END
