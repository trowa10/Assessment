using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentTemplateTypeModel
    {
        private readonly int _id;
        private readonly int _typeId;
        private readonly string _type;

        public AssessmentTemplateTypeModel(int id, int typeId, string type)
        {
            _id = id;
            _typeId = typeId;
            _type = type;
        }

        public int Id => _id;

        public int TypeId => _typeId;

        public string Type => _type;
    }
}
