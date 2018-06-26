using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class SchoolAdmin
    {
        public long AdminId { get; set; }
        public long SchoolId { get; set; }
        public string UserId { get; set; }

        public Schools School { get; set; }
        public Users User { get; set; }
    }
}
