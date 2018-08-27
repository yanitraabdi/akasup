using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Interfaces
{
    public interface IGeneralInterface<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync(int? CurrentPage, int? PageSize, int? TotalRecords);
        Task<bool> AddAsync(TEntity entity, string userId);
        Task<bool> DeleteAsync(string Id, string userId);
        Task<bool> UpdateAsync(TEntity entity, string userId);
    }
}
