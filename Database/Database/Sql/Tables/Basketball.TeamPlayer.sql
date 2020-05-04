IF OBJECT_ID(N'Basketball.TeamPlayer') IS NULL
BEGIN
Create table Basketball.TeamPlayer
(
    PlayerId int not null IDENTITY(1,1) PRIMARY key,
    TeamId int not null FOREIGN key REFERENCES BasketBall.BasketballTeam(TeamId),
    FirstName NVARCHAR(32) not null,
    LastName NVARCHAR(32) not null,
    JerseyNum int not null,
    Position NVARCHAR(32) not null
)
END

/****************************

 * Unique Constraints
 ****************************//*

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND kc.[name] = N'UK_Person_PersonAddress_PersonId_AddressTypeId'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [UK_Person_PersonAddress_PersonId_AddressTypeId] UNIQUE NONCLUSTERED
   (
      PersonId,
      AddressTypeId
   )
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.Person')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_Person'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_Person] FOREIGN KEY
   (
      PersonId
   )
   REFERENCES Person.Person
   (
      PersonId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.AddressType')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_AddressType'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_AddressType] FOREIGN KEY
   (
      AddressTypeId
   )
   REFERENCES Person.AddressType
   (
      AddressTypeId
   );
END;
*/