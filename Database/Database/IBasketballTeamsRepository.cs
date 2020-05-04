using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;

namespace Database
{
    public interface IBasketballTeamsRepository
    {
        IReadOnlyList<BasketballTeam> RetrieveBasketballTeams();

        BasketballTeam FetchBasketballTeam(int teamId);

        BasketballTeam GetBasketballTeam(string name);

    }
}
