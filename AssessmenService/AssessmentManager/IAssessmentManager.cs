using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentManager
    {
        Task<int> GetAssessmentId(int year, int formid);
    }
}
