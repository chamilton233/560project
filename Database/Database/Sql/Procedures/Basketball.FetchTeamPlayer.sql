/*
This procedure fetches a TeamPlayer row from the TeamPlayer table.  It takes a PlayerId
and returns the associated record's TeamId, FirstName, LastName, JerseyNum, and Position.
*/
CREATE OR ALTER PROCEDURE Basketball.FetchTeamPlayer
   @PlayerId int
AS

SELECT TP.TeamId, TP.FirstName,TP.LastName, TP.JerseyNum, TP.Position
FROM Basketball.TeamPlayer TP
WHERE  TP.PlayerId = @PlayerId;
GO