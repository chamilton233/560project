DECLARE @ConferenceStaging TABLE
(    
   Name NVARCHAR(32)
);

/***************************** Modify values here *****************************/

INSERT Basketball.Conference(Name)
VALUES   
 (N'East'),
 (N'West')

/******************************************************************************/

--MERGE Basketball.Conference T
--USING @ConferenceStaging S ON S.ConferenceId = T.ConferenceId
--WHEN MATCHED AND NOT EXISTS
--    (
--        SELECT S.Name
--        INTERSECT
--        SELECT T.Name
--    ) THEN
--   UPDATE
--   SET 
--        Name = S.Name
--WHEN NOT MATCHED THEN
--   INSERT(Name)
--   VALUES(S.Name);
