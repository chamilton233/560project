CREATE OR ALTER PROCEDURE Basketball.FetchBasketballTeam
   @TeamId int
AS

select T.Name, T.ConferenceId
from Basketball.BasketballTeam T
where T.TeamId = @TeamId
GO