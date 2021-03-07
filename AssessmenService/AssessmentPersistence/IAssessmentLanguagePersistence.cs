using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentLanguagePersistence
    {
        Task<IReadOnlyCollection<LanguageModel>> GetAsync();
    }
}
