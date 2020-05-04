using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;

namespace Database.DataDelegates
{
    class RetrievePlayerStatsDataDelegate: DataReaderDelegate<IReadOnlyList<PlayerStats>>
    {
        public RetrievePlayerStatsDataDelegate()
    : base("Basketball.RetrievePlayerStats")
        { }

        public override IReadOnlyList<PlayerStats> Translate(SqlCommand command, IDataRowReader reader)
        {
            var playerStats = new List<PlayerStats>();

            while (reader.Read())
            {
                playerStats.Add(new PlayerStats(
                    reader.GetInt32("PlayerId"),
                    reader.GetInt32("Points"),
                    reader.GetInt32("Assists"),
                    reader.GetInt32("FTAttempts"),
                    reader.GetInt32("FTMade"),
                    reader.GetInt32("Rebounds"),
                    reader.GetInt32("Blocks"),
                    reader.GetInt32("Steals")));
            }
            return playerStats;
        }
    }
}
   

