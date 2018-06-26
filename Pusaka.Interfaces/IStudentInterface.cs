using Pusaka.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Interfaces
{
    public interface IStudentInterface : IGeneralInterface<Students>
    {
        Task<bool> BulkAdd(List<Students> entities);
    }
}
