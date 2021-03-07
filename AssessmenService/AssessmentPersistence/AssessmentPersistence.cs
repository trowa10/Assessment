using Microsoft.EntityFrameworkCore;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public class AssessmentPersistence : IAssessmentPersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentPersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<int> GetAssessmentId(int id)
        {

            var assessmentId = await _dataContext.AssessmentTemplates
               .Where(x => x.Id == id)
               .Select(x => x.Id)
               .FirstOrDefaultAsync();

            return assessmentId;
        }
    }
}
