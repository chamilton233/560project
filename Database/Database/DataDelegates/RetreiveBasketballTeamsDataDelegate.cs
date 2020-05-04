using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using Database.Model;

namespace Database.DataDelegates
{
    internal class RetreiveBasketballTeamsDataDelegate: DataReaderDelegate<IReadOnlyList<BasketballTeam>>
    {
        public RetreiveBasketballTeamsDataDelegate()
: base("Basketball.RetrievePlayerStats")
        { }

        public override IReadOnlyList<BasketballTeam> Translate(SqlCommand command, IDataRowReader reader)
        {
            var playerStats = new List<BasketballTeam>();

            while (reader.Read())
            {
                playerStats.Add(new BasketballTeam(
                    reader.GetInt32("TeamId"),
                    reader.GetString("Name"),
                    reader.GetInt32("ConferenceId")));
            }
            return playerStats;
        }
    }
}
