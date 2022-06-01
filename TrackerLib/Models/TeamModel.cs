﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier of the team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
