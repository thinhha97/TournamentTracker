﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerUI.Interface
{
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel prizeModel);
    }
}
