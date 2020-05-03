CREATE OR ALTER PROCEDURE Basketball.GetTeamPlayer
   @FirstName NVARCHAR(32),
   @LastName Nvarchar(32)
AS

SELECT TP.PlayerId, TP.TeamId, TP.JerseyNum, Tp.Postion
FROM Basketball.TeamPlayer TP
WHERE Tp.FristName= @FirstName and Tp.LastName= @LastName 