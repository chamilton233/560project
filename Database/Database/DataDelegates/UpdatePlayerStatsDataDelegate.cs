using Database.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Database.DataDelegates
{
    internal class UpdatePlayerStatsDataDelegate : NonQueryDataDelegate<PlayerStats>
    {
        public readonly int playerId;
        public readonly int points;
        public readonly int assists;
        public readonly int fTAttempts;
        public readonly int fTMade;
        public readonly int rebounds;
        public readonly int blocks;
        public readonly int steals;

        public UpdatePlayerStatsDataDelegate(int playerId, int points, int assists, int fTAttempts,
int fTMade, int rebounds, int blocks, int steals) : base("Basketball.UpdatePlayerStats")
        {

            this.playerId = playerId;
            this.points = points;
            this.assists = assists;
            this.fTAttempts = fTAttempts;
            this.fTMade = fTMade;
            this.rebounds = rebounds;
            this.blocks = blocks;
            this.steals = steals;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("PlayerId", playerId);
            command.Parameters.AddWithValue("Points", points);
            command.Parameters.AddWithValue("Assists", assists);
            command.Parameters.AddWithValue("FTAttempts", fTAttempts);
            command.Parameters.AddWithValue("FTMade", fTMade);
            command.Parameters.AddWithValue("Rebounds", rebounds);
            command.Parameters.AddWithValue("Blocks", blocks);
            command.Parameters.AddWithValue("Steals", steals);
        }

        public override PlayerStats Translate(SqlCommand command)
        {
            return new PlayerStats(playerId, points, assists, fTAttempts, fTMade, rebounds, blocks, steals);
        }
    }
}
