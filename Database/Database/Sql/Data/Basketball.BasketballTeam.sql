DECLARE @BasketballTeamStaging TABLE
(    
    Name NVARCHAR(128) NOT NULL UNIQUE,
    ConferenceId INT

);

/***************************** Modify values here *****************************/

INSERT @BasketballTeamStaging(Name, ConferenceId)
VALUES
    (N'Bucks', 1),
    (N'Raptors', 1),
    (N'Celtics', 1),
    (N'Heat', 1),
    (N'Pacers', 1),
    (N'Lakers', 2),
    (N'Clippers', 2),
    (N'Nuggets', 2),
    (N'Jazz', 2),
    (N'Thunder', 2)
;



/******************************************************************************/

MERGE Basketball.BasketballTeam T
USING @BasketballTeamStaging S ON S.Name = T.Name
WHEN MATCHED AND NOT EXISTS
    (
        SELECT S.Name, S.ConferenceId
        INTERSECT
        SELECT T.Name, S.ConferenceId
    ) THEN
   UPDATE
   SET
        Name = S.Name
WHEN NOT MATCHED THEN
   INSERT(Name, ConferenceId)
   VALUES(S.Name, S.ConferenceId);
