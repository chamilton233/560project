using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Model
{
    public class Conference
    {
        public int ConferenceId { get; }
        public string Name { get; }

        public Conference(int conferenceId, string name)
        {
            ConferenceId = conferenceId;
            Name = name;
        }
    }
}
