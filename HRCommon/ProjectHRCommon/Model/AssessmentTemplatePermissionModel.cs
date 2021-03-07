using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentTemplatePermissionModel
    {
        private readonly int _id;
        private readonly int _assessmentTemplateId;
        private readonly AssessmentTemplateModel _assessmentTemplateModel;
        private readonly int _permissionId;

        public AssessmentTemplatePermissionModel(int id, int assessmentTemplateId, int permissionId, AssessmentTemplateModel assessmentTemplateModel)
        {
            _id = id;
            _assessmentTemplateId = assessmentTemplateId;
            _permissionId = permissionId;
            _assessmentTemplateModel = assessmentTemplateModel;
        }

        public int Id => _id;

        public int AssessmentTemplateId => _assessmentTemplateId;

        public int PermissionId => _permissionId;

        public AssessmentTemplateModel AssessmentTemplateModel => _assessmentTemplateModel;
    }
}
