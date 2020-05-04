using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;

namespace Database
{
    public class SqlBasketballTeamsrepository : IBasketballTeamsRepository
    {

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
