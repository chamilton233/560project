using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class TeamPlayer
    {
        public int PlayerId { get; }
        public int TeamId { get; }
        public string FirstName { get;  }
        public string LastName { get; }
        public int JerseyNumber { get; }
        public string Position { get;}//enum maybe

        public TeamPlayer(int playerId, int teamId, string firstName, string lastName,
   int jerseyNumber, string postion)
        {
            PlayerId = playerId;
            TeamId = teamId;
            FirstName = firstName;
            LastName = lastName;
            JerseyNumber = jerseyNumber;
            Position = postion;
        }
    }
}
