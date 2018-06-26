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
    public class UserService : IUserInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();

        public async Task<bool> Add(Users entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsonData", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "s_insert_TVChannel",
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
                    "s_get_TVChannel",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<Users> Get(int Id)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@tvId", Id);

                return await sqlConnection.QuerySingleOrDefaultAsync<Users>(
                    "s_get_TVChannel_by_id",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                return await sqlConnection.QueryAsync<Users>(
                    "s_get_TVChannel",
                    null,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> Update(Users entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@UserId", userId);

                await sqlConnection.ExecuteAsync(
                    "s_update_TVChannel",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
