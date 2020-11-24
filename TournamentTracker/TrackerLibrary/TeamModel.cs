using System.Collections.Generic;
using System;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }

        
    }
}
