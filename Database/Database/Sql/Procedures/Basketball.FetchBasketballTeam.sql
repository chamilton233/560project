CREATE OR ALTER PROCEDURE Basketball.CreatePlayer
   @TeamId int
AS

select T.Name, T.ConferenceId
from Basketball.BasketballTeam T
where T.TeamId = @TeamId
GO