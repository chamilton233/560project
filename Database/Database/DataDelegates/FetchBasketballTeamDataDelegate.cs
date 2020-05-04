using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;

namespace Database.DataDelegates
{
    class FetchBasketballTeamDataDelegate : DataReaderDelegate<BasketballTeam>
    {
        private readonly int teamId;

        public FetchBasketballTeamDataDelegate(int teamId)
           : base("Basketball.FetchBasketballTeam")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("TeamId", SqlDbType.Int);
            p.Value = teamId;
        }

        public override BasketballTeam Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(teamId.ToString());

            return new BasketballTeam(teamId,
               reader.GetString("Name"),
               reader.GetInt32("ConferenceId"));

        }
    }
}
