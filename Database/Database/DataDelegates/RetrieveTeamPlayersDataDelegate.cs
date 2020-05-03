using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;
namespace Database.DataDelegates
{
    class RetrieveTeamPlayersDataDelegate : DataReaderDelegate<IReadOnlyList<TeamPlayer>>
    {
        public RetrieveTeamPlayersDataDelegate()
            :base("Basketball.RetrieveTeamPlayers")
        { }
        public override IReadOnlyList<TeamPlayer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var teamPlayers = new List<TeamPlayer>();

            while (reader.Read())
            {
                teamPlayers.Add(new TeamPlayer(
                    reader.GetInt32("PlayerId"),
                    reader.GetInt32("TeamId"), 
                    reader.GetString("FristName"),
                    reader.GetString("LastName"), 
                    reader.GetInt32("JerseyNum"),
                    reader.GetString("Postion")));
            }
            return teamPlayers;
        }
    }
}
