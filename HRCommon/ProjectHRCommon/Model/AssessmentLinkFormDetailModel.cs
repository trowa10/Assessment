using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLinkFormDetailModel
    {
        private readonly int _id;
        private readonly int _assessmentUserstatusId;
        private readonly string _templateName;
        private readonly int _templateYear;
        private readonly int _linkedAssessmentUserstatusId;
        private readonly string _linkedTemplateName;
        private readonly int _linkedTemplateYear;
        private readonly int _createdBy;
        private readonly DateTime _createdDate;

        public AssessmentLinkFormDetailModel(int id, int assessmentUserstatusId, string templateName, int templateYear, int linkedAssessmentUserstatusId, string linkedTemplateName, int linkedTemplateYear, int createdBy, DateTime createdDate)
        {
            _id = id;
            _assessmentUserstatusId = assessmentUserstatusId;
            _templateName = templateName;
            _templateYear = templateYear;
            _linkedAssessmentUserstatusId = linkedAssessmentUserstatusId;
            _linkedTemplateName = linkedTemplateName;
            _linkedTemplateYear = linkedTemplateYear;
            _createdBy = createdBy;
            _createdDate = createdDate;
        }

        public int Id => _id;

        public int AssessmentUserstatusId => _assessmentUserstatusId;

        public string TemplateName => _templateName;

        public int TemplateYear => _templateYear;

        public int LinkedAssessmentUserstatusId => _linkedAssessmentUserstatusId;

        public string LinkedTemplateName => _linkedTemplateName;

        public int LinkedTemplateYear => _linkedTemplateYear;

        public int CreatedBy => _createdBy;

        public DateTime CreatedDate => _createdDate;
    }
}
