using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.Classes
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel tournamentModel)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamModelOrder(tournamentModel.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);
            Console.WriteLine(byes.ToString());

            tournamentModel.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(tournamentModel, rounds);
        }
        private static void CreateOtherRounds(TournamentModel tournamentModel, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = tournamentModel.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currentMatchup = new MatchupModel();

            while(round <= rounds)
            {
                foreach(MatchupModel matchup in previousRound)
                {
                    currentMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });

                    if (currentMatchup.Entries.Count > 1)
                    {
                        currentRound.Add(currentMatchup);
                        currentMatchup.MatchupRound = round;
                        currentMatchup = new MatchupModel();
                    }
                }
                tournamentModel.Rounds.Add(currentRound);
                previousRound = currentRound;

                currentRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teamModels)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currentMatchupModel = new MatchupModel();
            foreach (TeamModel teamModel in teamModels)
            {
                currentMatchupModel.Entries.Add(new MatchupEntryModel { TeamCompeting = teamModel });

                if (byes > 0 || currentMatchupModel.Entries.Count > 1)
                {
                    currentMatchupModel.MatchupRound = 1;
                    output.Add(currentMatchupModel);
                    currentMatchupModel = new MatchupModel();
                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberOfByes(int rounds, int teamCount)
        {
            int totalTeams = 1;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            return totalTeams - teamCount;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while (val < teamCount)
            {
                output++;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamModelOrder(List<TeamModel> teamModels)
        {
            return teamModels.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
