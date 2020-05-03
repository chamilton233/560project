using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;


namespace Database.DataDelegates
{
    class FetchPlayerStatsDataDelegate : DataReaderDelegate<PlayerStats>
    {
        private readonly int playerId;

        public FetchPlayerStatsDataDelegate(int playerId)
           : base("Basketball.FetchPlayerStats")
        {
            this.playerId = playerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PlayerId", SqlDbType.Int);
            p.Value = playerId;
        }

        public override PlayerStats Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(playerId.ToString());

            return new PlayerStats(playerId,
               reader.GetInt32("Points"),
               reader.GetInt32("Assists"),
               reader.GetInt32("FTAttempts"),
               reader.GetInt32("FTMade"),
               reader.GetInt32("Rebounds"),
               reader.GetInt32("Blocks"),
               reader.GetInt32("Steals"));
        }
    }
}
