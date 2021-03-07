using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]

    public class AssessmentUserStatusFiltersDTO
    {
        //list of twwid included or list of twwid excluded
        [JsonProperty("twwIds")]
        public int[] TwwIds { get; set; }

        [JsonProperty("permissionId")]
        public int? PermissionId { get; set; }

        [JsonProperty("siteCode")]
        public string SiteCode { get; set; }

        //selected assessmentId
        [JsonProperty("formTypeId")]
        public int? FormTypeId { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }
    }
}
