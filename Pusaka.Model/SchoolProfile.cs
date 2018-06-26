using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class SchoolProfile
    {
        public long RowId { get; set; }
        public long SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolBrand { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public Schools School { get; set; }
    }
}
