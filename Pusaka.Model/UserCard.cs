using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class UserCard
    {
        public long RowId { get; set; }
        public string UserId { get; set; }
        public string UserCardId { get; set; }
        public byte CardType { get; set; }
        public string CardImage { get; set; }

        public Users User { get; set; }
    }
}
