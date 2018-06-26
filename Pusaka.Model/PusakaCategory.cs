using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class PusakaCategory
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageFile { get; set; }
        public string Tag { get; set; }
        public short Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
