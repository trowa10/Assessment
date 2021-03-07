using ProjectHRCommon.Constants;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IQuestionnaireDomPersistence
    {
        Task<IReadOnlyCollection<DomModel>> GetByIds(IReadOnlyCollection<int> ids, int assessmetemplateId,
            string languageCode = Globals.DEFAULT_LANGUAGE_CODE);
    }
}
