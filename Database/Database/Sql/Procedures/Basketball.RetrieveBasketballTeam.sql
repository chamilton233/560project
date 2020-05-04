/*
This procedure retrieves a basketball team from the BasketballTeam table.
It returns the TeamId, Name, and ConferenceId of the team.
*/
CREATE OR ALTER PROCEDURE Basketball.RetrieveBasketballTeam

AS

SELECT T.TeamId, T.Name, T.ConferenceId
FROM Basketball.BasketballTeam T;

GO