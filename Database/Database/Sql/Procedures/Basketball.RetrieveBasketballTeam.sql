CREATE OR ALTER PROCEDURE Basketball.RetrieveBasketballTeam

AS

Select T.TeamId, T.Name, T.ConferenceId
from Basketball.BaksetballTeam T;

GO