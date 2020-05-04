CREATE OR ALTER PROCEDURE Basketball.GetBasketballTeam
   @Name NVARCHAR(32)
AS

select T.TeamId, T.ConferenceId
from Basketball.BasketballTeam T
where @Name =T.Name


GO