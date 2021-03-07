using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentLanguageManager
    {
        Task<IReadOnlyCollection<LanguageModel>> GetLanguagesAsync();
    }
}
