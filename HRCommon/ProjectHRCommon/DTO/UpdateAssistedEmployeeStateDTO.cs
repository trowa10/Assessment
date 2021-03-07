using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UpdateAssistedEmployeeStateDTO
    {
        public string twwid { get; set; }
        public string assistingManagerTwwid { get; set; }
        public string actualManagerTwwid { get; set; }
    }
}
