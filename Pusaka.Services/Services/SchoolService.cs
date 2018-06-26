using Dapper;
using Pusaka.Interfaces;
using Pusaka.Library;
using Pusaka.Model;
using Pusaka.Services.DbContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Services.Services
{
    public class SchoolService : ISchoolInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();
        public async Task<bool> Add(Schools entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsondata", entity);
                dynamicParameters.Add("@userid", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_ADD_MISSION",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@id", id);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_DELETE_MISSION",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public Task<Schools> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Schools>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Schools entity, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
