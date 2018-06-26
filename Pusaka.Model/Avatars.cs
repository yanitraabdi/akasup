using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Avatars
    {
        public Avatars()
        {
            UserProfile = new HashSet<UserProfile>();
        }

        public long AvatarId { get; set; }
        public string AvatarName { get; set; }
        public string ImageFile { get; set; }
        public byte AvatarStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
