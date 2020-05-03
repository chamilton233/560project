CREATE OR ALTER PROCEDURE Basketball.CreatePlayer
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Postition NVARCHAR(32),
   @JerseyNum int,
   @TeamId int, 
   @PlayerId INT OUTPUT
AS

INSERT Basketball.TeamPlayer(FirstName, LastName, JerseyNum, Postition, TeamId)
VALUES(@FirstName, @LastName, @JerseyNum, @Postition, @TeamId);

SET @PersonId = SCOPE_IDENTITY();
GO