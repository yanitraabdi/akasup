using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Interfaces
{
    public interface IGeneralInterface<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<bool> Add(TEntity entity, string userId);
        Task<bool> DeleteAsync(string Id, string userId);
        Task<bool> Update(TEntity entity, string userId);
    }
}
