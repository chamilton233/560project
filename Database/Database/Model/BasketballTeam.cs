using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class BasketballTeam
    {
        public int TeamId { get; }
        public string Name { get;  }
        public int ConfereneceId { get; }

        public  BasketballTeam(int teamId, string name, int confereneceId)
        {
            TeamId = teamId;
            Name = name;
            ConfereneceId = confereneceId;
        }
    }
}
