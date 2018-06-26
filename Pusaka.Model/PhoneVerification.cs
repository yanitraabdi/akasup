using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class PhoneVerification
    {
        public long PhoneVerification1 { get; set; }
        public string PhoneNo { get; set; }
        public string SessionId { get; set; }
        public string VerificationCode { get; set; }
        public byte VerificationStatus { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
