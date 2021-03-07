using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;


namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusCurrentDoneIdDTO
    {
        [JsonProperty("currentid")]
        public int CurrentId { get; set; }
        [JsonProperty("doneid")]
        public int DoneId { get; set; }
    }
}
