using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class BasketballGame
    {
        public int GameId { get; }
        public DateTimeOffset StartTime { get; }
        public int Score { get; }

        public BasketballGame(int gameId, DateTimeOffset startTime, int score)
        {
            GameId=gameId;
            StartTime = startTime;
            Score = score;
        }
    }
}
