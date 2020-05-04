CREATE OR ALTER PROCEDURE Basketball.GetBasketballTeam
   @Name NVARCHAR(32)
AS

select T.TeamId, T.ConferenceId
from Basketball.BaksetballTeam T
where @Name =T.Name


GO