using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;
using Database.Model;
using DataAccess;
using Database.DataDelegates;

namespace Database
{
    public class SqlBasketballTeamsrepository : IBasketballTeamsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlBasketballTeamsrepository(string connetionString)
        {
            executor = new SqlCommandExecutor(connetionString);
        }

        public BasketballTeam FetchBasketballTeam(int teamId)
        {
            if (teamId < 0)
                throw new ArgumentException("playerId cannot be less than 0", nameof(teamId));

            var d = new FetchBasketballTeamDataDelegate(teamId);
            return executor.ExecuteReader(d);
        }

        public BasketballTeam GetBasketballTeam(string name)
        {

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new GetBasketballTeamDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<BasketballTeam> RetrieveBasketballTeams()
        {
            var d = new RetreiveBasketballTeamsDataDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
