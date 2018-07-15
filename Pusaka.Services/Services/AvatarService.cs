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
    public class AvatarService : IAvatarInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();

        public async Task<bool> Add(Avatars entity, string userId)
        {            
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsonData", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_AVATAR_POST",
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
                    "BO_AVATAR_DELETE",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<Avatars> Get(int Id)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@avatarId", Id);

                return await sqlConnection.QuerySingleOrDefaultAsync<Avatars>(
                    "BO_AVATAR_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Avatars>> GetAllAsync()
        {
            {
                using (var sqlConnection = new SqlConnection(conn))
                {
                    await sqlConnection.OpenAsync();
                    return await sqlConnection.QueryAsync<Avatars>(
                        "BO_AVATAR_GET",
                        null,
                        commandType: CommandType.StoredProcedure);
                }
            }
        }

        public async Task<IEnumerable<Avatars>> GetAllAsync(int avatarId, string avatarName, byte avatarStatus,
            int currentPage, int pageSize, string orderByColumn, bool isAscending, int totalRecords)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@AvatarId", avatarId);
                dynamicParameters.Add("@AvatarName", avatarName);
                dynamicParameters.Add("@AvatarStatus", avatarStatus);
                dynamicParameters.Add("@CurrentPage", currentPage);
                dynamicParameters.Add("@PageSize", pageSize);
                dynamicParameters.Add("@OrderByColumn", orderByColumn);
                dynamicParameters.Add("@IsAscending", isAscending);
                dynamicParameters.Add("@TotalRecords", totalRecords);

                return await sqlConnection.QueryAsync<Avatars>(
                    "BO_AVATAR_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> Update(Avatars entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsonData", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_AVATAR_PUT",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
