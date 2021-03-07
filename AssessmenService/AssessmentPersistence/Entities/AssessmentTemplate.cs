using AssessmentPersistence.Abstract;
using AssessmentPersistence.Entities.LookUpTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;


namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]
    public class AssessmentTemplate : AssessmentBaseClass
    {
        public int Year { get; set; }

        public string Title { get; set; }

        public string Version { get; set; }

        public int ScoreCriteriaId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string AssessmentCode { get; set; }

        public Assessment Assessment { get; set; }

        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public AssessmentFormType AssessmentFormType { get; set; }
        
        public IReadOnlyCollection<TemplatePermission> TemplatePermissions  { get; set; }

        public bool isStash { get; set; }

        public IReadOnlyCollection<TemplateQuestionnaire> TemplateQuestionnaires { get; set; }

        public IReadOnlyCollection<TemplateCategoryOrder> TemplateCategoryOrders { get; set; }

    }
}
