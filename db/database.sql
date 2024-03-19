CREATE TABLE `recipes` (
  `RecipeID` int NOT NULL AUTO_INCREMENT,
  `RecipeName` varchar(255) NOT NULL,
  `Ingredients` text NOT NULL,
  `Instructions` text NOT NULL,
  PRIMARY KEY (`RecipeID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci