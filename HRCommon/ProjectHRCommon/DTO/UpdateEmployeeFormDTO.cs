using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UpdateEmployeeFormDTO
    {
        public int userId { get; set; }

        public int currentUserId { get; set; }

        public int actualManagerUserId { get; set; }

        public bool isManagerForm { get; set; }


    }
}
