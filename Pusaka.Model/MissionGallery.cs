using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class MissionGallery
    {
        public long RowId { get; set; }
        public long MissionId { get; set; }
        public string ImageFile { get; set; }
        public int Sequence { get; set; }
        public byte GalleryStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
