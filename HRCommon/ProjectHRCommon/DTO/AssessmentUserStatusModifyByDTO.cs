using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusModifyByDTO
    {
        public int Id { get; set; } //AssessmentUserState Primary Key column     
        public int ModifiedBy { get; set; }

        public int StatusId { get; set; }
    }
}
