﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        /// <summary>
        /// Save a new prize for to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information includes its Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
