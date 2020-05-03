CREATE OR ALTER PROCEDURE Basketball.FetchTeamPlayer
   @PlayerId int
AS

SELECT TP.TeamId, TP.FirstName, TP.FirstName, TP.JerseyNum, Tp.Postion
FROM Basketball.TeamPlayer TP
WHERE  TP.PlayerId = @PlayerId;
go