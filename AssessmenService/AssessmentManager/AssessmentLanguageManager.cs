using AssessmentPersistence;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentLanguageManager : IAssessmentLanguageManager
    {
        private readonly IAssessmentLanguagePersistence _assessmentLanguagePersistence;
        public AssessmentLanguageManager(IAssessmentLanguagePersistence assessmentLanguagePersistence)
        {
            _assessmentLanguagePersistence = assessmentLanguagePersistence;
        }

        public async Task<IReadOnlyCollection<LanguageModel>> GetLanguagesAsync()
        {
            return await _assessmentLanguagePersistence.GetAsync();
        }
    }
}
