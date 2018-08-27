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

        public async Task<bool> AddAsync(Badge entity, string userId)
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

        public async Task<IEnumerable<Badge>> GetAllAsync(int? CurrentPage, int? PageSize, int? TotalRecords)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@CurrentPage", CurrentPage);
                dynamicParameters.Add("@PageSize", PageSize == 0 ? 500 : PageSize);
                dynamicParameters.Add("@TotalRecords", TotalRecords == 0 ? 500 : TotalRecords);

                return await sqlConnection.QueryAsync<Badge>(
                    "BO_BADGE_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Badge>> GetBadges(int BadgeStatus, int CurrentPage, int PageSize)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@BadgeStatus", BadgeStatus);
                dynamicParameters.Add("@CurrentPage", CurrentPage);
                dynamicParameters.Add("@PageSize", PageSize == 0 ? 500 : PageSize);

                return await sqlConnection.QueryAsync<Badge>(
                    "BO_BADGE_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> UpdateAsync(Badge entity, string userId)
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
