/*
This procedure retrieves a TeamPlayer record from the TeamPlayers table.
It retrieves the PlayerId, TeamId, FirstName, LastName, JerseyNum, and Position.
*/
CREATE OR ALTER PROCEDURE Basketball.RetrieveTeamPlayers

AS

SELECT T.PlayerId,T.TeamId, T.FirstName, T.LastName, T.JerseyNum, T.Position
FROM Basketball.TeamPlayer T;

GO