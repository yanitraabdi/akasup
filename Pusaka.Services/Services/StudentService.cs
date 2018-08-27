using Pusaka.Interfaces;
using Pusaka.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Services.Services
{
    public class StudentService : IStudentInterface
    {
        public Task<bool> AddAsync(Students entity, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Students> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Students>> GetAllAsync(int? CurrentPage, int? PageSize, int? TotalRecords)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Students entity, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BulkAdd(List<Students> entities)
        {
            throw new NotImplementedException();
        }
    }
}
