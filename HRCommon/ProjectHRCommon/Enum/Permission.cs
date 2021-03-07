using System.ComponentModel;

namespace ProjectHRCommon.Enum
{
    public enum Permission
    {
        [Description("HRM")]
        HRM = 2,
        [Description("HRBP")]
        HRBP = 3,
        [Description("Manager")]
        Manager = 4,
        [Description("Employee")]
        Employee = 5,
        [Description("BM")]
        BM = 6
    }
}
