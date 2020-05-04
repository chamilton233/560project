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
        public readonly string position;//enum maybe

        public CreatePlayerDataDelegate(int teamId, string firstName, string lastName,
        int jerseyNumber, string position) : base("Basketball.CreatePlayer")
        {
            this.teamId = teamId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jerseyNumber = jerseyNumber;
            this.position = position;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("TeamId", SqlDbType.Int);
            p.Value = teamId;
            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstName;
            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastName;
            p = command.Parameters.Add("JerseyNum", SqlDbType.Int);
            p.Value = jerseyNumber;
            p = command.Parameters.Add("Position", SqlDbType.NVarChar);
            p.Value = position;
            p = command.Parameters.Add("PlayerId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }

        public override TeamPlayer Translate(SqlCommand command)
        {
            return new TeamPlayer((int)command.Parameters["PlayerId"].Value, teamId, firstName, lastName, jerseyNumber, position);
        }
    }
}
