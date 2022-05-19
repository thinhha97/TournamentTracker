using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Interfaces;

namespace TrackerLib.Classes
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Save a new price for to the database.
        /// </summary>
        /// <param name="model">The price information.</param>
        /// <returns>The price information includes its Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
