using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserManagerAssistedDTO
    {
        public int TwwId { get; set; }
        public int ActualManagerTwwId { get; set; }
        public DateTime EndDate { get; set; } //UTC
    }
}
