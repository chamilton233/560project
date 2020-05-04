/*
This procedure fetches a row from the PlayerStats table.
It takes the associated PlayerId and returns all the of the stat
attributes for that row including Points, Assists, FTAttempts, FTMade,
Rebounds, Block, and Steals.
*/
CREATE OR ALTER PROCEDURE Basketball.FetchPlayerStats
   @PlayerId INT
AS

SELECT S.Points, S.Assists, S.FTAttempts, S.FTMade, S.Rebounds, S.Blocks, S.Steals
FROM Basketball.PlayerStats S
WHERE  S.PlayerId = @PlayerId;
GO