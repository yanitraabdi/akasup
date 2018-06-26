using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class UserAccount
    {
        public long AccountId { get; set; }
        public string UserId { get; set; }
        public long AccountTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte LoginFailed { get; set; }
        public DateTime RetryLoginAt { get; set; }
        public byte AccountStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
