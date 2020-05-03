using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Database.Model;
using System.Data.SqlClient;

namespace Database.DataDelegates
{
    internal class GetTeamPlayerDataDelegate : DataReaderDelegate<TeamPlayer>
    {
        private readonly string firstName;
        private readonly string lastName;

        public GetTeamPlayerDataDelegate(string firstName, string lastName)
           : base("Basketball.GetTeamPlayer")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
        }

        public override TeamPlayer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new TeamPlayer(
                    reader.GetInt32("PlayerId"),
                    reader.GetInt32("TeamId"),
                    firstName,
                    lastName,
                    reader.GetInt32("JerseyNum"),
                    reader.GetString("Postion"));
        }
    }
}
