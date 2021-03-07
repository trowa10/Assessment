using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusIdModel
    {
        private readonly int _id;

        public AssessmentUserStatusIdModel(int id)
        {
            _id = id;
        }

        public int Id => _id;
    }
}
