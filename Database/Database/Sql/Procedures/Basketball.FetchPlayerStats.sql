CREATE OR ALTER PROCEDURE Basketball.FetchPlayerStats
   @PlayerId int
AS

SELECT S.Points, S.Assists, S.FTAttempts, S.FTMade, S.Rebounds, S.Blocks, S.Steals
FROM Basketball.PlayerStats S
WHERE  S.PlayerId = @PlayerId;
go