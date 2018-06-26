using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class UserMissions
    {
        public long UserMissionId { get; set; }
        public long MissionId { get; set; }
        public string UserId { get; set; }
        public byte MissionStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
