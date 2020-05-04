/*
This procedure updates a TeamPlayer record.  It finds the appropriate
record by PlayerId, then updates the associated attributes with the 
user-provided information.
*/
CREATE or ALTER PROCEDURE Basketball.UpdateTeamPlayer
   @PlayerId INT,
   @TeamId INT,
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @JerseyNum INT,
   @Position NVARCHAR(32)
AS
BEGIN 
	SET NOCOUNT ON;
	UPDATE Basketball.TeamPlayer
	SET TeamId= @TeamId,FirstName=@FirstName, LastName=@LastName, JerseyNum=@JerseyNum
	,Position= @Position
	WHERE PlayerId=@PlayerId;
END
GO