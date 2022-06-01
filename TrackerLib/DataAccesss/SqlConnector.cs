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
        /// Save a new prize for to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information includes its Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(
                GlobalConfig.GetConnectionString("TournamentTracker"))
                )
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("Prizes_InsertPrize", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
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
    }
}
