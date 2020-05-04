/*
This procedure fetches a basketball team by taking input in the form of a TeamId.
It matches the TeamId to a team stored in the database.  It returns the name of the team
and the conference the team belongs to.
*/
CREATE OR ALTER PROCEDURE Basketball.FetchBasketballTeam
   @TeamId INT
AS

SELECT T.Name, T.ConferenceId
FROM Basketball.BasketballTeam T
WHERE T.TeamId = @TeamId
GO