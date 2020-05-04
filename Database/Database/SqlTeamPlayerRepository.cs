using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;
using DataAccess;
using Database.DataDelegates;

namespace Database
{
    public class SqlTeamPlayerRepository : ITeamPlayerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamPlayerRepository(string connetionString)
        {
            executor = new SqlCommandExecutor(connetionString);
        }

        public TeamPlayer CreateTeamPlayer(int teamId, string firstName, string lastName, int jerseyNum, string postion)
        {
            if (teamId <0)
                throw new ArgumentException("teamid cannot be less than 0", nameof(teamId));

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            if (jerseyNum < 0 )
                throw new ArgumentException("jerseyNum cannot be less than 0", nameof(jerseyNum));

            if (string.IsNullOrWhiteSpace(postion))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(postion));

            var d = new CreatePlayerDataDelegate(teamId, firstName,lastName,jerseyNum,postion);
            return executor.ExecuteNonQuery(d);

        }

        public TeamPlayer FetchTeamPlayer(int playerId)
        {
            if (playerId < 0)
                throw new ArgumentException("PlayerId cannot be less than 0", nameof(playerId));

            var d = new FetchTeamPlayerDataDelegate(playerId);
            return executor.ExecuteReader(d);
        }

        public TeamPlayer GetTeamPlayer(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            var d = new GetTeamPlayerDataDelegate(firstName, lastName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<TeamPlayer> RetrieveTeamPlayers()
        {
            var d = new RetrieveTeamPlayersDataDelegate();
            return executor.ExecuteReader(d);
        }

        public TeamPlayer UpdateTeamPlayer(int playerId, int teamId, string firstName, string lastName, int jerseyNum, string postion)
        {
            if (teamId < 0)
                throw new ArgumentException("teamid cannot be less than 0", nameof(teamId));

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            if (jerseyNum < 0)
                throw new ArgumentException("jerseyNum cannot be less than 0", nameof(jerseyNum));

            if (string.IsNullOrWhiteSpace(postion))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(postion));

            var d = new UpdateTeamPlayerDataDelegate(playerId, teamId, firstName, lastName, jerseyNum, postion);
            return executor.ExecuteNonQuery(d);
        }
    }
}
