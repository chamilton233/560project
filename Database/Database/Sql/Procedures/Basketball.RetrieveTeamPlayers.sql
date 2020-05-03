CREATE OR ALTER PROCEDURE Basketball.RetrieveTeamPlayers

AS

Select T.PlayerId, T.TeamId, T.FirstName, T.LastName, T.JerseyNum, T.Postion
from Basketball.TeamPlayer T;

GO