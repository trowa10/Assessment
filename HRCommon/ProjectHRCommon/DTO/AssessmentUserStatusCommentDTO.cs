using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;


namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusCommentDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("twwId")]
        public int TwwId { get; set; }

        [JsonProperty("isEdited")]
        public bool IsEdited { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("createdDateTime")]
        public DateTime CreatedDateTime { get; set; }

        [JsonProperty("modifiedDateTime")]
        public DateTime ModifiedDateTime { get; set; }
    }
}
