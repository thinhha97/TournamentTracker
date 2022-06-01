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
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString("TournamentTracker")))
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
                GlobalConfig.GetConnectionString("TournamentTracker"))
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
                GlobalConfig.GetConnectionString("TournamentTracker")))
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

        public List<PersonModel> ReadPerson_All()
        {
            List<PersonModel> result;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.GetConnectionString("TournamentTracker"))
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
                GlobalConfig.GetConnectionString("TournamentTracker"))
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
    }
}
