using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class ManagerEmployeeAssistDTO
    {
        [JsonProperty("actualmanagertwwid")]
        public int ActualManagerTwwId { get; set; }
        [JsonProperty("assistingmanagertwwid")]
        public int AssistingManagerTwwId { get; set; }
        [JsonProperty("assistingemployeestwwids")]
        public int[] AssistingEmployeesTwwIds { get; set; }
        [JsonProperty("enddate")]
        public DateTime EndDate { get; set; }
    }
}
