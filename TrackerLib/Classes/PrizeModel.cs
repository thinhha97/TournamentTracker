﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the price.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The numeric identifier for the place.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The friendly name for the place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The fixed amount earns || 0
        /// </summary>
        public decimal PriceAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take || 0 (fraction of 1, ex: 0.5).
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
