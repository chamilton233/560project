IF OBJECT_ID(N'BasketBall.PlayerStats') IS NULL
BEGIN

create table BasketBall.PlayerStats
(
    PlayerId int not null FOREIGN key REFERENCES Basketball.TeamPlayer(PlayerId),
    Points int not null,
    Assists int not null,
    FtAttempts int not null,
    FTMade int not null,
    Rebounds int not null,
    Blocks int not null,
    Steals int not null
)
END;

/****************************
 * Unique Constraints
 ****************************//*

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