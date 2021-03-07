using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentStatusAndLevelDTO
    {
        public int Id { get; set; } //AssessmentUserState Primary Key column
        public int EmployeeLevelId { get; set; }
        public int StatusId { get; set; }
        public int ModifiedBy { get; set; }
    }
}
