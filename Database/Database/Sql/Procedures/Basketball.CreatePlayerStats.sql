﻿/*
This procedure creates a PlayerStats record.
It takes user input using functions provided by the SqlPlayerStatsRepository.
*/
CREATE OR ALTER PROCEDURE Basketball.CreatePlayerStats
	@PlayerId Int,	
   @Points int,
   @Assists int,
   @FTAttempts int,
   @FTMade int,
   @Rebounds int,
   @Blocks int,
   @Steals int
AS

INSERT Basketball.PlayerStats(PlayerId, Points,Assists, FTAttempts, FTMade
,Rebounds,Blocks, Steals)
VALUES(@PlayerId, @Points, @Assists, @FTAttempts, @FTMade,@Rebounds, @Blocks,@Steals);

GO