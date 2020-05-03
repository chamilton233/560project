Create PROCEDURE Basketball.CreatePlayerStats
   @PlayerId int,
   @Points int,
   @Assists int,
   @FTAttempts int,
   @FTMade int,
   @Rebounds int,
   @Blocks int,
   @Steals int
AS
begin 
	set Nocount On;
	update Basketball.PlayerStats
	set Points= @Points,Assists=@Assists, FTAttempts=@FTAttempts, FTMade=@FTMade
	,Rebounds= @Rebounds,Blocks=@Blocks, Steals=@Steals
	where PlayerId=@PlayerId;
end
GO