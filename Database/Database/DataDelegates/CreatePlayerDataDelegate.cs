using Database.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Database.DataDelegates
{
    internal class CreatePlayerDataDelegate : NonQueryDataDelegate<TeamPlayer>
    {
        public readonly int teamId;
        public readonly string firstName;
        public readonly string lastName;
        public readonly int jerseyNumber;
        public readonly string postion;//enum maybe

        public CreatePlayerDataDelegate(int teamId, string firstName, string lastName,
        int jerseyNumber, string postion) : base("Basketball.CreatePlayer")
        {
            this.teamId = teamId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jerseyNumber = jerseyNumber;
            this.postion = postion;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("TeamId", teamId);
            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
            command.Parameters.AddWithValue("JerseyNumber", jerseyNumber);
            command.Parameters.AddWithValue("Postion", postion);

        }

        public override TeamPlayer Translate(SqlCommand command)
        {
            return new TeamPlayer((int)command.Parameters["PlayerId"].Value, teamId, firstName, lastName, jerseyNumber, postion);
        }
    }
}
