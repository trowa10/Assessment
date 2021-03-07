using AssessmentPersistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentManager : IAssessmentManager
    {
        private readonly IAssessmentPersistence _assessmentPersistence;

        public AssessmentManager(IAssessmentPersistence assessmentPersistence)
        {
            _assessmentPersistence = assessmentPersistence;
        }
        public async Task<int> GetAssessmentId(int year, int formid)
        {
            //TODO delete 
            return await _assessmentPersistence.GetAssessmentId(year, formid);
        }
    }
}
