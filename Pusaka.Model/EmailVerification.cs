using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class EmailVerification
    {
        public long RowId { get; set; }
        public string Email { get; set; }
        public string ActiviationCode { get; set; }
        public byte IsValid { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
