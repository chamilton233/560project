CREATE OR ALTER PROCEDURE Basketball.RetrieveTeamPlayers

AS

Select T.TeamId, T.Name, T.ConferenceId
from Basketball.BasketballTeam T;

GO