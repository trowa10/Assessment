using System.ComponentModel;
namespace ProjectHRCommon.Enum
{
    public enum AssessmentState
    {
        [Description("Not done")]
        NotStarted = 0,
        [Description("Started")]
        Started = 1,
        [Description("Done")]
        Done = 2
    }
}
