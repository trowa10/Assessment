using Microsoft.EntityFrameworkCore;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLanguagePersistence : IAssessmentLanguagePersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentLanguagePersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IReadOnlyCollection<LanguageModel>> GetAsync()
        {
            var result = await _dataContext
                .Languages
                .AsNoTracking()
                .Select(x => new LanguageModel(x.Id, x.Code, x.Description))
                .ToListAsync();

            return result.AsReadOnly();
        }
    }
}
