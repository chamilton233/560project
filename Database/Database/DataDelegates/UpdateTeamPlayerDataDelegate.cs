using Database.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Database.DataDelegates
{
    internal class UpdateTeamPlayerDataDelegate : DataDelegate
    {
        public readonly int playerId;
        public readonly int teamId;
        public readonly string firstName;
        public readonly string lastName;
        public readonly int jerseyNumber;
        public readonly string postion;//enum maybe

        public CreatePlayerDataDelegate( int playerId,int teamId, string firstName, string lastName,
int jerseyNumber, string postion) : base("the sql procdure name goes here")
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

    }
}
