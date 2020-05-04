/*
This procedure updates a PlayerStats record.  It takes user input from the GUI,
finds the matching record by PlayerId, then updates that records attributes.
*/
CREATE or ALTER PROCEDURE Basketball.UpdatePlayerStats
   @PlayerId INT,
   @Points INT,
   @Assists INT,
   @FTAttempts INT,
   @FTMade INT,
   @Rebounds INT,
   @Blocks INT,
   @Steals INT
AS
BEGIN 
	SET NOCOUNT ON;
	UPDATE Basketball.PlayerStats
	SET Points= @Points,Assists=@Assists, FTAttempts=@FTAttempts, FTMade=@FTMade
	,Rebounds= @Rebounds,Blocks=@Blocks, Steals=@Steals
	WHERE PlayerId=@PlayerId;
END
GO