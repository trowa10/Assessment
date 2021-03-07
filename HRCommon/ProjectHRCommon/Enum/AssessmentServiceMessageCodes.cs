using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectHRCommon.Enum
{
    public enum AssessmentServiceMessageCodes
    {
        [Description("There is no available form to update.")]
        ASM1 = 1,
        [Description("The form was successfully updated.")]
        ASM2 = 2
    }
}
