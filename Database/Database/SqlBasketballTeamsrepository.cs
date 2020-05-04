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
            throw new NotImplementedException();
        }

        public BasketballTeam GetBasketballTeam(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<BasketballTeam> RetrievePlayersStats()
        {
            throw new NotImplementedException();
        }
    }
}
