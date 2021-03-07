using ProjectHRCommon.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAnswerPersistence
    {
        Task<bool> Insert(int AssessmentAnswerId, IReadOnlyCollection<AnswerDTO> answerDTOs);
    }
}
