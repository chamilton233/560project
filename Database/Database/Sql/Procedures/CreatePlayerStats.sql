CREATE OR ALTER PROCEDURE Basketball.CreatePlayerStats
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Points int,
   @Assists int,
   @FTAttempts int,
   @FTMade int,
   @Rebounds int,
   @Blocks int,
   @Steals int
AS

INSERT Basketball.PlayerStats(PlayerId, Points,Assists, FTAttempts, FTMade
,Rebounds,Blocks, Steals)
VALUES((Select PlayerId from Basketball.TeamPlayer where FirstName = @FirstName and LastName = @LastName)
, @Points, @Assists, @FTAttempts, @FTMade,@Rebounds, @Blocks,@Steals);

GO