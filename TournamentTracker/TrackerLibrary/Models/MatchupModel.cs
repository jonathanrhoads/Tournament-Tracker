using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of matched up teams.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the tournament.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the integer value of the round.
        /// </summary>
        public int MatchRound { get; set; }
    }
}
