using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;
using DataAccess;
using Database.DataDelegates;

namespace Database
{
    class SqlPlayerStatsRepository : IPlayerStatsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerStatsRepository(string connetionString)
        {
            executor = new SqlCommandExecutor(connetionString);
        }

        public PlayerStats CreatePlayerStats(int playerId, int points, int assists, int fTAttempts, int fTMade, int rebounds, int blocks, int steals)
        {
            if (playerId < 0)
                throw new ArgumentException("playerId cannot be less than 0", nameof(playerId));

            if ( points < 0)
                points = 0;

            if ( assists < 0)
                assists = 0;
            if (fTAttempts < 0)
                fTAttempts = 0;
            if (fTMade < 0)
                 fTMade = 0;
            if ( rebounds < 0)
                rebounds = 0;
            if ( blocks < 0)
                blocks = 0;
            if ( steals < 0)
                steals = 0;

            var d = new CreatePlayerStatsDataDelegate( playerId,  points,  assists,  fTAttempts, fTMade,   rebounds,  blocks,  steals);
            return executor.ExecuteNonQuery(d);

        }

        public PlayerStats FetchPlayerStats(int playerId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PlayerStats> RetrievePlayersStats()
        {
            throw new NotImplementedException();
        }

        public PlayerStats UpdatePlayerStats(int playerId, int points, int assists, int fTAttempts, int fTMade, int rebounds, int blocks, int steals)
        {
            if (playerId < 0)
                throw new ArgumentException("playerId cannot be less than 0", nameof(playerId));

            if (points < 0)
                points = 0;

            if (assists < 0)
                assists = 0;
            if (fTAttempts < 0)
                fTAttempts = 0;
            if (fTMade < 0)
                fTMade = 0;
            if (rebounds < 0)
                rebounds = 0;
            if (blocks < 0)
                blocks = 0;
            if (steals < 0)
                steals = 0;

            var d = new UpdatePlayerStatsDataDelegate(playerId, points, assists, fTAttempts, fTMade, rebounds, blocks, steals);
            return executor.ExecuteNonQuery(d);
        }
    }
}
