IF OBJECT_ID(N'BasketBall.BasketballTeam') IS NULL
BEGIN
create table BasketBall.BasketballTeam
(
    TeamId int not null IDENTITY(1,1) PRIMARY Key,
    Name NVARCHAR(128) not null,
    ConferenceId int not null FOREIGN key REFERENCES BasketBall.Conference(ConferenceId),
    UNIQUE
    (
        Name
    )
)
END;

/****************************
 * Unique Constraints
 ****************************/ 
/* possibly good refence material below IDk what the fuck it does really but seems important 
IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Person.AddressType')
         AND kc.[name] = N'UK_Person_AddressType_Name'
   )
BEGIN
   ALTER TABLE Person.AddressType
   ADD CONSTRAINT [UK_Person_AddressType_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
*/