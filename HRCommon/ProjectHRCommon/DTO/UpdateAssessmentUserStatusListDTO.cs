using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UpdateAssessmentUserStatusListDTO
    {
        public IReadOnlyCollection<int> AssessmentUserStatusIds { get; set; }
    }
}
