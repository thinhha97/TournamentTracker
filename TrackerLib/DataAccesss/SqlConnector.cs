using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Classes;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel personModel)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", personModel.FirstName);
                p.Add("@LastName", personModel.LastName);
                p.Add("@EmailAddress", personModel.EmailAddress);
                p.Add("@CellPhoneNumber", personModel.CellPhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("People_InsertPerson", p, commandType: CommandType.StoredProcedure);

                personModel.Id = p.Get<int>("@id");

                return personModel;
            }
        }

        /// <summary>
        /// Save a new prize to the database.
        /// </summary>
        /// <param name="prizeModel">The prize information.</param>
        /// <returns>The prize information includes its Id.</returns>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.ConnectionString)
                )
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", prizeModel.PlaceNumber);
                p.Add("@PlaceName", prizeModel.PlaceName);
                p.Add("@PrizeAmount", prizeModel.PrizeAmount);
                p.Add("@PrizePercentage", prizeModel.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("Prizes_InsertPrize", p, commandType: CommandType.StoredProcedure);

                prizeModel.Id = p.Get<int>("@id");

                return prizeModel;
            }
        }

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", teamModel.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("Teams_InsertTeam", p, commandType: CommandType.StoredProcedure);

                teamModel.Id = p.Get<int>("@id");

                foreach (PersonModel teamMember in teamModel.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", teamModel.Id);
                    p.Add("@PersonId", teamMember.Id);

                    conn.Execute("TeamMembers_InsertTeamMember", p, commandType: CommandType.StoredProcedure);
                }

                return teamModel;
            }
        }

        public TournamentModel CreateTournament(TournamentModel tournamentModel)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.ConnectionString))
            {
                SaveTournament(conn, tournamentModel);
                SaveTournamentEntries(conn, tournamentModel);
                SaveTournamentPrizes(conn, tournamentModel);
                SaveTournamentRounds(conn, tournamentModel);

                return tournamentModel;
            }
        }
        private void SaveTournamentRounds(IDbConnection conn, TournamentModel tournamentModel)
        {
            foreach (List<MatchupModel> round in tournamentModel.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", tournamentModel.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    conn.Execute("Matchups_InsertMatchup", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchupEntryModel matchupEntryModel in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        if (matchupEntryModel.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", matchupEntryModel.ParentMatchup.Id);
                        }
                        if (matchupEntryModel.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingId", matchupEntryModel.TeamCompeting.Id);
                        }
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        conn.Execute("MatchupEntries_InsertMatchupEntry", p, commandType: CommandType.StoredProcedure);

                    }
                }
            }
        }
        private void SaveTournament(IDbConnection conn, TournamentModel tournamentModel)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", tournamentModel.TournamentName);
            p.Add("@EntryFee", tournamentModel.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            conn.Execute("Tournaments_InsertTournament", p, commandType: CommandType.StoredProcedure);

            tournamentModel.Id = p.Get<int>("@id");
        }

        private void SaveTournamentEntries(IDbConnection conn, TournamentModel tournamentModel)
        {
            foreach (TeamModel teamModel in tournamentModel.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", tournamentModel.Id);
                p.Add("@TeamId", teamModel.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("TournamentEntries_InsertTournamentEntry", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentPrizes(IDbConnection conn, TournamentModel tournamentModel)
        {
            foreach (PrizeModel prizeModel in tournamentModel.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", tournamentModel.Id);
                p.Add("@PrizeId", prizeModel.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("TournamentPrizes_InsertTournamentPrize", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<PersonModel> ReadPerson_All()
        {
            List<PersonModel> result;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.ConnectionString)
                )
            {
                result = conn.Query<PersonModel>("People_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

        public List<TeamModel> ReadTeam_All()
        {
            List<TeamModel> result;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.ConnectionString)
                )
            {
                result = conn.Query<TeamModel>("Teams_GetAll", commandType: CommandType.StoredProcedure).ToList();

                foreach (TeamModel team in result)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = conn.Query<PersonModel>(
                        "GetTeamMembersByTeamId",
                        p,
                        commandType: CommandType.StoredProcedure)
                        .ToList();
                }
            }
            return result;
        }

        public List<TournamentModel> ReadTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString))
            {
                output = conn.Query<TournamentModel>("Tournaments_GetAll").ToList();
                foreach (TournamentModel tournamentModel in output)
                {
                    tournamentModel.Prizes = conn.Query<PrizeModel>("Prizes_GetByTournamentId", tournamentModel.Id).ToList();
                    tournamentModel.EnteredTeams = conn.Query<TeamModel>("GetTeamsByTournamentId", tournamentModel.Id).ToList();
                    foreach (TeamModel teamModel in tournamentModel.EnteredTeams)
                    {
                        var dp = new DynamicParameters();
                        dp.Add("@TeamId", teamModel.Id);
                        teamModel.TeamMembers = conn.Query<PersonModel>(
                            "GetTeamMembersByTeamId",
                            dp,
                            commandType: CommandType.StoredProcedure)
                            .ToList();

                    }
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", tournamentModel.Id);
                    List<MatchupModel> matchupModels = conn.Query<MatchupModel>(
                        "GetMatchupsByTournamentId",
                        p,
                        commandType: CommandType.StoredProcedure)
                        .ToList();
                    foreach (MatchupModel matchupModel in matchupModels)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchupModel.Id);
                        matchupModel.Entries = conn.Query<MatchupEntryModel>(
                            "GetMatchupEntriesByMatchupId",
                            p,
                            commandType: CommandType.StoredProcedure)
                            .ToList();
                    }
                }
            }
            return output;
        }
    }
}
