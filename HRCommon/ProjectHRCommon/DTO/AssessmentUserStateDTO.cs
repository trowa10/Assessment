using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStateDTO
    {
        public int Id { get; set; } //AssessmentUserState Primary Key column
        public int StatusId { get; set; }
        public int ModifiedBy { get; set; }
    }
}
