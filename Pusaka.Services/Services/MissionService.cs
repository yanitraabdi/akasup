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
    public class MissionService : IMissionInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();

        public async Task<bool> Add(Missions entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsondata", entity);

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

        public async Task<Missions> Get(int? CategoryId, string City, string MisName, int? MisStatus, int? CurrentPage, int? PageSize, string OrderByColumn, int? IsAscending, int? TotalRecords)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@CategoryID", CategoryId);
                dynamicParameters.Add("@City", City);
                dynamicParameters.Add("@MisName", MisName);
                dynamicParameters.Add("@MisStatus", MisStatus);
                dynamicParameters.Add("@CurrentPage", CurrentPage);
                dynamicParameters.Add("@PageSize", PageSize);
                dynamicParameters.Add("@OrderByColumn", OrderByColumn);
                dynamicParameters.Add("@IsAscending", IsAscending);
                dynamicParameters.Add("@TotalRecords", TotalRecords);

                return await sqlConnection.QuerySingleOrDefaultAsync<Missions>(
                    "BO_MISSION_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public Task<Missions> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Missions>> GetAllAsync(int? CategoryId, string City, string MisName, int? MisStatus, int? CurrentPage, int? PageSize, string OrderByColumn, int? IsAscending, int? TotalRecords)
        {
            using (var sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@CategoryID", CategoryId);
                dynamicParameters.Add("@City", City);
                dynamicParameters.Add("@MisName", MisName);
                dynamicParameters.Add("@MisStatus", MisStatus);
                dynamicParameters.Add("@CurrentPage", CurrentPage);
                dynamicParameters.Add("@PageSize", PageSize);
                dynamicParameters.Add("@OrderByColumn", OrderByColumn);
                dynamicParameters.Add("@IsAscending", IsAscending);
                dynamicParameters.Add("@TotalRecords", TotalRecords);

                return await sqlConnection.QueryAsync<Missions>(
                    "BO_MISSION_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public Task<IEnumerable<Missions>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Missions entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsondata", entity);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_UPDATE_MISSION",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
