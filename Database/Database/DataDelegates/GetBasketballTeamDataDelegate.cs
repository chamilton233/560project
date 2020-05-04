using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Database.Model;
using System.Data.SqlClient;

namespace Database.DataDelegates
{
    class GetBasketballTeamDataDelegate : DataReaderDelegate<BasketballTeam>
    {
        private readonly string name;

        public GetBasketballTeamDataDelegate(string name)
           : base("Basketball.GetBasketballTeam")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("Name", name);
        }

        public override BasketballTeam Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new BasketballTeam(
                    reader.GetInt32("TeamId"),
                    name,
                    reader.GetInt32("ConferenceId"));

        }
    }
}
