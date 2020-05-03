Create or alter PROCEDURE Basketball.UpdateTeamPlayer
   @PlayerId INT,
   @TeamId int,
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @JerseyNum int,
   @Postition NVARCHAR(32)
AS
begin 
	set Nocount On;
	update Basketball.TeamPlayer
	set TeamId= @TeamId,FirstName=@FirstName, LastName=@LastName, JerseyNum=@JerseyNum
	,Position= @Postition
	where PlayerId=@PlayerId;
end
GO