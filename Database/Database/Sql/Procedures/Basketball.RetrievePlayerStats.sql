CREATE OR ALTER PROCEDURE Basketball.RetrievePlayerStats

AS

Select S.PlayerId, S.Points, S.Assists, S.FTAttempts, S.FTMade, S.Rebounds, S.Blocks, S.Steals
from Basketball.PlayerStats S;

GO