using Pusaka.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pusaka.Interfaces
{
    public interface IBadgeInterface : IGeneralInterface<Badge>
    {
        Task<IEnumerable<Badge>> GetBadges(int BadgeStatus, int CurrentPage, int PageSize);
    }
}
