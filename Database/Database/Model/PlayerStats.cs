using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class PlayerStats
    {
        public int PlayerId { get; }
        public int Points { get; }
        public int Assists { get;  }
        public int FreeThrowsAttempts { get;  }
        public int FreeThrowsMade { get;  }
        public int Rebounds { get; }
        public int Blocks { get; }
        public int Steals { get; }

        public PlayerStats(int playerId, int points,int assists,int freeThrowsAttempts,
           int freeThrowsMade, int rebounds, int blocks, int steals )
        {
            PlayerId = playerId;
            Points = points;
            Assists = assists;
            FreeThrowsAttempts = freeThrowsAttempts;
            FreeThrowsMade = freeThrowsMade;
            Rebounds = rebounds;
            Blocks = blocks;
            Steals = steals;
        }
    }
}
