using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;

namespace Database.DataDelegates
{
    internal class FetchTeamPlayerDataDelegate : DataReaderDelegate<TeamPlayer>
    {
        private readonly int playerId;

        public FetchTeamPlayerDataDelegate(int playerId)
           : base("Basketball.FetchTeamPlayer")
        {
            this.playerId = playerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("PlayerId", SqlDbType.Int);
            p.Value = playerId;
        }

        public override TeamPlayer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(playerId.ToString());

            return new TeamPlayer(playerId,
               reader.GetInt32("TeamId"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetInt32("JerseyNum"),
               reader.GetString("Position"));
        }
    }
}
