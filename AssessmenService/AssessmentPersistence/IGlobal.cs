using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IGlobal
    {
        Task<AssessmentLinkFormDetailModel> Insert(int num1, int num2);
        Task<AssessmentLinkFormDetailModel> Insert(int num1, int num2,int num3);
    }
}
