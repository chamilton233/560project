using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class BasketballTeam
    {
        public int TeamId { get; }
        public string Name { get;  }
        public int ConferneceId { get; }

        public  BasketballTeam(int teamId, string name, int conferneceId)
        {
            TeamId = teamId;
            Name = name;
            ConferneceId = conferneceId;
        }
    }
}
