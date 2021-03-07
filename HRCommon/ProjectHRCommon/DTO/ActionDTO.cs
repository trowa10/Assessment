using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class ActionDTO
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        public static explicit operator ActionDTO(string act)
        {
            return new ActionDTO() {  Action = act };
        }

    }
}
