using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]

    public class Assessment
    {
        public int Id { get; set; }

        public string AssessmentCode { get; set; }

        public string Name { get; set; }

        public List<AssessmentTemplate> AssessmentTemplates { get; set; }
    }
}
