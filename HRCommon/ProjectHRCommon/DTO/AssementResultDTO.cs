using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssementResultDTO
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int UserStateID { get; set; }
        public string Result { get; set; }
    }

}
