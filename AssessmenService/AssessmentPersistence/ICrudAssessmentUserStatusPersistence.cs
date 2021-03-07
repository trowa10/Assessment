using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface ICrudAssessmentUserStatusPersistence
    {
        Task<int> Delete(int id);
        Task<int> DeleteAssessmentLinkForm(int id);
        Task<AssessmentUserCommentModel> Update(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO);
        Task<int> InsertAssessmentLinkForm(AssessmentLinkFormDTO assessmentLinkFormDTO);
    }
}
