using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface ICrudAssessmentPersistence
    {
        Task<int> Delete(int id);
        Task<AssessmentUserCommentModel> Update(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO);
    }
}
