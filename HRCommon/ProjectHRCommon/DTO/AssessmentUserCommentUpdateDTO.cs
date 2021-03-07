using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserCommentUpdateDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }      

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}
