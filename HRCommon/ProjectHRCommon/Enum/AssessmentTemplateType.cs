using System.ComponentModel;

namespace ProjectHRCommon.Enum
{
    public enum AssessmentTemplateType
    {
        [Description("N/A")]
        NA = 0,
        [Description("Performance Form")]
        PerformanceForm = 1,
        [Description("Salary Form")]
        SalaryForm = 2 
    }
}
