using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Classes
{
    public class TeamModel
    {
        /// <summary>
        /// List of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// The name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
