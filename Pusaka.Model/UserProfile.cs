using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class UserProfile
    {
        public long RowId { get; set; }
        public string UserId { get; set; }
        public long AvatarId { get; set; }
        public long BadgesId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MissionTaken { get; set; }
        public int MissionSuccess { get; set; }
        public int MissionFailed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public Avatars Avatar { get; set; }
        public Badge Badges { get; set; }
        public UserProfile Row { get; set; }
        public Users User { get; set; }
        public UserProfile InverseRow { get; set; }
    }
}
