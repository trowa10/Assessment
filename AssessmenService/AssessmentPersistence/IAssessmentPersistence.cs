using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentPersistence
    {
        Task<int> GetAssessmentId(int id);
    }
}
