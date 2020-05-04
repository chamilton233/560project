/*
This procedure gets the TeamId and ConferenceId of a team.
It uses the team's Name to match records.
*/
CREATE OR ALTER PROCEDURE Basketball.GetBasketballTeam
   @Name NVARCHAR(32)
AS

SELECT T.TeamId, T.ConferenceId
FROM Basketball.BasketballTeam T
WHERE @Name =T.Name
GO