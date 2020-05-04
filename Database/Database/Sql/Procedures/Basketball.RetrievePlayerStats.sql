/*
This procedure retrieves a PlayerStats record.
It returns all the stats associated with the record.
*/
CREATE OR ALTER PROCEDURE Basketball.RetrievePlayerStats

AS

SELECT S.PlayerId, S.Points, S.Assists, S.FTAttempts, S.FTMade, S.Rebounds, S.Blocks, S.Steals
FROM Basketball.PlayerStats S;

GO