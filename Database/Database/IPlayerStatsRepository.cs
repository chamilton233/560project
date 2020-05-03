using System;
using System.Collections.Generic;
using System.Text;
using Database.Model;

namespace Database
{
    interface IPlayerStatsRepository
    {
        PlayerStats CreatePlayerStats(int playerId, int points, int assists, int fTAttempts,
int fTMade, int rebounds, int blocks, int steals);

        PlayerStats UpdatePlayerStats(int playerId, int points, int assists, int fTAttempts,
int fTMade, int rebounds, int blocks, int steals);

        PlayerStats FetchPlayerStats(int playerId);

        IReadOnlyList<PlayerStats> RetrievePlayersStats();
    }
}
