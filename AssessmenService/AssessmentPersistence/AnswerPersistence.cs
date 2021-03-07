using AssessmentPersistence.Entities.LookUpTables;
using ProjectHRCommon.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AnswerPersistence : IAnswerPersistence
    {
        private readonly DataContext _dataContext;

        public AnswerPersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> Insert(int AssessmentAnswerId, IReadOnlyCollection<AnswerDTO> answerDTOs)
        {

            IReadOnlyCollection<Answer> answers = answerDTOs.Select(x => new Answer()
            {
                AssessmentAnswerId = AssessmentAnswerId,
                DomId = x.DomId,
                CategoryCode = x.CategoryCode,
                QuestionCode = x.QuestionCode,
                AnswerText = x.AnswerText,
                Points = x.Points,
                DateTimeCreatedUtc = DateTime.UtcNow
            })
            .ToList();

            _dataContext.AddRange(answers);
            return (await _dataContext.SaveChangesAsync()) > 0;
        }
    }
}
