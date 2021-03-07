using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{ 
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusIdDTO
    {
        [JsonProperty("assessmentuserstatusid")]
        public int Id { get; set; }

        public static explicit operator AssessmentUserStatusIdDTO(int id)
        {
            return new AssessmentUserStatusIdDTO() { Id = id };
        }

    }
}
