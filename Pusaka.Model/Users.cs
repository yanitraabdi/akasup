using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Users
    {
        public Users()
        {
            SchoolAdmin = new HashSet<SchoolAdmin>();
            Students = new HashSet<Students>();
            UserCard = new HashSet<UserCard>();
            UserProfile = new HashSet<UserProfile>();
        }

        public string UserId { get; set; }
        public byte RoleType { get; set; }
        public byte UserStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public ICollection<SchoolAdmin> SchoolAdmin { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<UserCard> UserCard { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
