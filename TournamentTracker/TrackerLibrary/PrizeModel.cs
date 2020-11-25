using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {

        /// <summary>
        /// Represents the finishing place as a number.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the finishing place as a name instead of a number.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the exact amount of winnings.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the winnings as a percentage.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
