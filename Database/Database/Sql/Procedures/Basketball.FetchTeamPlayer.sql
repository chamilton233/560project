CREATE OR ALTER PROCEDURE Basketball.FetchTeamPlayer
   @PlayerId int
AS

SELECT TP.TeamId, TP.FirstName, TP.LastName, TP.JerseyNum, Tp.Position
FROM Basketball.TeamPlayer TP
WHERE  TP.PlayerId = @PlayerId;
go