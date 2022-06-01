using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel personModel);
        TeamModel CreateTeam(TeamModel teamModel);
        TournamentModel CreateTournament(TournamentModel tournamentModel);
        List<PersonModel> ReadPerson_All();
        List<TeamModel> ReadTeam_All();
    }
}
