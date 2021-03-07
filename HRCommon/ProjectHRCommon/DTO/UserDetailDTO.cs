using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserDetailDTO
    {
        public string Twwid { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CountryIso2Code { get; set; }

        public string Country { get; set; }

        public string SiteCode { get; set; }

        public string Site { get; set; }

        public string SiteLocation { get; set; }

        public string Role { get; set; }

        public string OrgUnit { get; set; }

        public string Department { get; set; }

        public string ReportTo { get; set; }

        public string HireStartDate { get; set; }

        public string JobFamily { get; set; }

        public bool IsActive { get; set; }

        public bool IsExclude { get; set; }
    }
}
