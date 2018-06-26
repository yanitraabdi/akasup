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
    public class BadgeService : IBadgeInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();

        public async Task<bool> Add(Badge entity, string userId)
        {            
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsonData", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_BADGE_POST",
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
                    "BO_BADGE_DELETE",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<Badge> Get(int Id)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@badgeId", Id);

                return await sqlConnection.QuerySingleOrDefaultAsync<Badge>(
                    "BO_BADGE_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Badge>> GetAllAsync()
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                return await sqlConnection.QueryAsync<Badge>(
                    "BO_BADGE_GET",
                    null,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> Update(Badge entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsonData", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_BADGE_PUT",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
