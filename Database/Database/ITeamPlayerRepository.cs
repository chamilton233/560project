using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;

namespace Database
{
    interface ITeamPlayerRepository
    {
        TeamPlayer CreateTeamPlayer(int teamId, string firstName, string lastName, int jerseyNum, string postion);

        TeamPlayer UpdateTeamPlayer(int playerId, int teamId, string firstName, string lastName, int jerseyNum, string postion);

        TeamPlayer GetTeamPlayer(string firstNmae, string lastName);

        TeamPlayer FetchTeamPlayer(int playerId);

        IReadOnlyList<TeamPlayer> RetrieveTeamPlayers();
    }
}
