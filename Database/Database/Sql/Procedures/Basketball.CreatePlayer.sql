/*
This procedure creates a new player.
It takes user input using functions provided by the SqlTeamPlayerRepository.
*/
CREATE OR ALTER PROCEDURE Basketball.CreatePlayer
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Position NVARCHAR(32),
   @JerseyNum INT,
   @TeamId INT, 
   @PlayerId INT OUTPUT
AS

INSERT Basketball.TeamPlayer(FirstName, LastName, JerseyNum, Position, TeamId)
VALUES(@FirstName, @LastName, @JerseyNum, @Position, @TeamId);

SET  @PlayerId= SCOPE_IDENTITY();
GO