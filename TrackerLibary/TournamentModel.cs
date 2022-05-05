using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string? TournamentName { get; set; }
        /// <summary>
        /// How many fee does one team have to contribute to attend this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Which team attend this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Price list for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// How many round does this tournament have.
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();
    }
}
