using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Badge
    {

        public long BadgeId { get; set; }
        public string ImageFile { get; set; }
        public string BadgeName { get; set; }
        public byte BadgeStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

    public class ListBadges : ExceptionModel
    {
        public ListBadges()
        {
            listBadges = new List<Badge>();
        }
        public IEnumerable<Badge> listBadges { get; set; }
    }

    public class SingleBadges : ExceptionModel
    {
        public SingleBadges()
        {
            Badges = new Badge();
        }
        public Badge Badges { get; set; }
    }
}
