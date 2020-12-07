using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

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
        public int MatchupRound { get; set; }
    }
}