using EnumStringValues;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pusaka.Library
{
    public enum ExceptionType
    {
        [StringValue("Success")]
        SUCCESS = 0,

        [StringValue("Custom")]
        CUSTOM = 10000,

        [StringValue("Catch")]
        CATCH = 40002,

        [StringValue("Instance")]
        INSTANCE = 40003,

        [StringValue("Wrong Password")]
        WRONG_PASSWORD = 40004,
    }
}
