using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class GameTeam
    {
        public int TeamId { get; }
        public int GameId { get; }
        public bool IsHome { get; }
        public int TeamScore { get; }

        public GameTeam(int teamId, int gameId, bool isHome, int teamScore)
        {
            TeamId = teamId;
            GameId = gameId;
            IsHome = isHome;
            TeamId = TeamId;
        }
    }
}
