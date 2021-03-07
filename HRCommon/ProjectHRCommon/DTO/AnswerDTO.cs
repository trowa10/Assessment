using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AnswerDTO
    {
        
        [JsonProperty("domid")]
        public int DomId { get; set; }

        [JsonProperty("categorycode")]
        public string CategoryCode { get; set; }

        [JsonProperty("questioncode")]
        public string QuestionCode { get; set; }

        [JsonProperty("answertext")]
        public string AnswerText { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; } //score
    }
}
