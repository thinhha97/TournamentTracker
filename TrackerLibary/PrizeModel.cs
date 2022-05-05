using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary
{
    public class PrizeModel
    {
        /// <summary>
        /// The number of this price.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name of this price.
        /// </summary>
        public string? PlaceName { get; set; }
        /// <summary>
        /// The reward price for this place.
        /// </summary>
        public decimal PriceAmount { get; set; }
        /// <summary>
        /// How many percent does this price hold in all prices.
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
