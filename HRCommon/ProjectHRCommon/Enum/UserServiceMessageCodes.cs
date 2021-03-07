using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectHRCommon.Enum
{
    public enum UserServiceMessageCodes
    {
        [Description("Successfully included user to the assisting manager.")]
        USM1 = 1,
        [Description("One or more parameters is invalid.")]
        USM2 = 2
    }
}
