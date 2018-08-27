using Dapper;
using Newtonsoft.Json;
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
    public class CategoryService : ICategoryInterface
    {
        internal const string conn = Constants.ConnectionString;
        ConnectionFactory _conn = new ConnectionFactory();

        public async Task<bool> AddAsync(Category entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                string jsonData = JsonConvert.SerializeObject(entity);
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsondata", jsonData);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_CATEGORY_POST",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public async Task<bool> DeleteAsync(string Id, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@id", Id);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_CATEGORY_DELETE",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }

        public Task<Category> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllAsync(int? CurrentPage, int? PageSize, int? TotalRecords)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Status", 255);
                dynamicParameters.Add("@CurrentPage", CurrentPage == 0 ? 1 : CurrentPage);
                dynamicParameters.Add("@PageSize", PageSize == 0 ? 500 : PageSize);
                dynamicParameters.Add("@TotalRecords", TotalRecords == 0 ? 500 : TotalRecords);

                return await sqlConnection.QueryAsync<Category>(
                    "BO_CATEGORY_GET",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> UpdateAsync(Category entity, string userId)
        {
            using (var sqlConnection = new SqlConnection(conn))
            {
                string jsonData = JsonConvert.SerializeObject(entity);
                await sqlConnection.OpenAsync();

                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@jsondata", jsonData);
                dynamicParameters.Add("@userId", userId);

                await sqlConnection.ExecuteAsync(
                    "BO_CATEGORY_PUT",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);

                return true;
            }
        }
    }
}
