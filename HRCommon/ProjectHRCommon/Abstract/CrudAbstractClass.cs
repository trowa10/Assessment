using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace ProjectHRCommon.Abstract
{
    [ExcludeFromCodeCoverage]
    public abstract class CrudAbstractClass
    {
        public virtual async Task<int> DeleteData(int id)
        {
            return await Task.Run(() => 0);
        }

        public virtual async Task<int> DeleteData1(int id)
        {
            return await Task.Run(() => 0);
        }

        public virtual async Task<int> DeleteDatabyAssessmentUserStatusId(int id)
        {
            return await Task.Run(() => 0);
        }


        public virtual async Task<AssessmentUserCommentModel> UpdateData(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO)
        {
            return await Task.Run(() => new AssessmentUserCommentModel(0, 0, false, DateTime.UtcNow));
        }

        public virtual async Task<int> InsertData(AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            return await Task.Run(() => 0);
        }

        public virtual async Task<AssessmentLinkFormDetailModel> InsertData1(AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            return await Task.Run(() => new AssessmentLinkFormDetailModel(0, 0, "", 0, 0, "", 0, 0, DateTime.UtcNow));
        }

    }
}
