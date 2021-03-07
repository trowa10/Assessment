using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ProjectHRCommon
{
    [ExcludeFromCodeCoverage]
    public static class AssessmentHelper
    {
        public static bool IsAssessmentTemplateAvailable(DateTime startDate, DateTime endDate)
        {
            DateTime dateNowLocal = DateTime.Now.ToLocalTime();

            bool isAvailable = dateNowLocal >= startDate.ToLocalTime();

            return isAvailable;
        }


        public static string GeneratePin(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
