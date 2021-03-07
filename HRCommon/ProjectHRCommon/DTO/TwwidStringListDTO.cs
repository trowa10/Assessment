using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class TwwidStringListDTO
    {
        [JsonProperty("twwIds")]
        public string[] TwwIds { get; set; }
    }
}
