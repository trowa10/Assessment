using AssessmentPersistence.Entities;
using AssessmentPersistence.Entities.LookUpTables;
using Microsoft.EntityFrameworkCore;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentAnswersPersistence : IAssessmentAnswersPersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentAnswersPersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private async Task<AssessmentAnswer> GetAssessmentUserAnswerById(int id)
        {
            return await _dataContext.AssessmentAnswers
            .AsNoTracking()
            .Where(x => x.AssessmentUserStatusId == id)
            .FirstOrDefaultAsync();
        }

        private async Task<AssessmentAnswer> GetAssessmentAnswerByAssessmentUserStatus(int assessmentUserStatusId)
        {
            return await _dataContext.AssessmentAnswers
                .Include(x => x.AssessmentUserStatus)
                .Include(x => x.Answers)

            .AsNoTracking()
            .Where(x => x.AssessmentUserStatusId == assessmentUserStatusId)
            .FirstOrDefaultAsync();
        }

        private async Task<IReadOnlyCollection<AssessmentAnswer>> GetAssessmentUserAnswerByIds(List<int> ids)
        {
            return await _dataContext.AssessmentAnswers
            .AsNoTracking()
            .Where(x => ids.Contains(x.AssessmentUserStatusId))
            .ToListAsync();
        }

        public async Task<AssessmentAnswersModel> GetAssessmentAnswers(int assessmentUserStatusId)
        {
            var result = await _dataContext.AssessmentAnswers.AsNoTracking()
                .Where(x => x.AssessmentUserStatusId == assessmentUserStatusId && x.IsActive == true)
                .FirstOrDefaultAsync();

            if (result != null)
                return new AssessmentAnswersModel(result.AssessmentUserStatusId, result.TotalScore, result.AnswersJson, result.DateManagerApproved,
                    result.DateEmployeeApproved, result.LanguageCode, result.ApproverTwwId, result.DateTimeSubmitted);

            return null;
        }


        public async Task<bool> UpdateAssessmentAsnwerClearAnswer(AssessmentUserStatusModifyByDTO assessmentUserStatusModifyByDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            var assessmentUserAnswer = await GetAssessmentUserAnswerById(assessmentUserStatusModifyByDTO.Id);

            if (assessmentUserAnswer != null)
            {
                assessmentUserAnswer.ModifiedBy = assessmentUserStatusModifyByDTO.ModifiedBy;
                assessmentUserAnswer.AnswersJson = string.Empty;
                assessmentUserAnswer.DateModified = DateTime.UtcNow;
                assessmentUserAnswer.DateEmployeeApproved = null;
                assessmentUserAnswer.DateManagerApproved = null;

                _dataContext.Entry(assessmentUserAnswer).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<bool> UpdateAssessmentAsnwerClearAnswer(IReadOnlyCollection<AssessmentUserStatusModifyByDTO> assessmentUserStatusModifyByDTOs)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            var idList = assessmentUserStatusModifyByDTOs.Select(x => x.Id).ToList();
            var assessmentUserAnswers = await GetAssessmentUserAnswerByIds(idList);
            if (assessmentUserAnswers != null)
            {
                foreach (var ans in assessmentUserAnswers)
                {
                    foreach (var dto in assessmentUserStatusModifyByDTOs)
                    {
                        ans.ModifiedBy = dto.ModifiedBy;
                        ans.AnswersJson = string.Empty;
                        ans.DateModified = DateTime.UtcNow;
                        ans.DateEmployeeApproved = null;
                        ans.DateManagerApproved = null;
                        ans.DateTimeSubmitted = null;
                        ans.TotalScore = 0;
                    }
                }

                _dataContext.AssessmentAnswers.UpdateRange(assessmentUserAnswers);
                await _dataContext.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> InsertAnswer(AssessmentUserAnswerDTO assessmentAnswerDTO)
        {
            AssessmentAnswer assessmentAnswer = new AssessmentAnswer();
            assessmentAnswer.AssessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;
            assessmentAnswer.TotalScore = assessmentAnswerDTO.TotalScore;
            assessmentAnswer.AnswersJson = assessmentAnswerDTO.AnswersJson;
            assessmentAnswer.DateManagerApproved = assessmentAnswerDTO.DateManagerApproved;
            assessmentAnswer.DateEmployeeApproved = assessmentAnswerDTO.DateEmployeeApproved;
            assessmentAnswer.ModifiedBy = assessmentAnswerDTO.ModifiedBy;
            assessmentAnswer.IsActive = true;
            assessmentAnswer.LanguageCode = assessmentAnswerDTO.LanguageCode;
            assessmentAnswer.ApproverTwwId = assessmentAnswerDTO.ApproverTwwId;
            assessmentAnswer.ShowEmpLevel = assessmentAnswerDTO.ShowEmpLevel;

            if (assessmentAnswerDTO.StatusId == (int)AssessmentState.Done)
                assessmentAnswer.DateTimeSubmitted = DateTime.UtcNow;
            else
                assessmentAnswer.DateTimeSubmitted = null;


            _dataContext.Add(assessmentAnswer);

            return (await _dataContext.SaveChangesAsync()) > 0;
        }

        public async Task<bool> InsertAnswer_v2(AssessmentUserAnswerDTO assessmentAnswerDTO)
        {

            AssessmentAnswer assessmentAnswer = new AssessmentAnswer();
            assessmentAnswer.AssessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;
            assessmentAnswer.TotalScore = assessmentAnswerDTO.TotalScore;
            assessmentAnswer.AnswersJson = assessmentAnswerDTO.AnswersJson;
            assessmentAnswer.DateManagerApproved = assessmentAnswerDTO.DateManagerApproved;
            assessmentAnswer.DateEmployeeApproved = assessmentAnswerDTO.DateEmployeeApproved;
            assessmentAnswer.ModifiedBy = assessmentAnswerDTO.ModifiedBy;
            assessmentAnswer.IsActive = true;
            assessmentAnswer.LanguageCode = assessmentAnswerDTO.LanguageCode;
            assessmentAnswer.ApproverTwwId = assessmentAnswerDTO.ApproverTwwId;
            assessmentAnswer.ShowEmpLevel = assessmentAnswerDTO.ShowEmpLevel;


            if (assessmentAnswerDTO.StatusId == (int)AssessmentState.Done)
                assessmentAnswer.DateTimeSubmitted = DateTime.UtcNow;
            else
                assessmentAnswer.DateTimeSubmitted = null;


            _dataContext.Add(assessmentAnswer);
            await _dataContext.SaveChangesAsync();


            IReadOnlyCollection<Answer> answers = assessmentAnswerDTO.Answers.Select(x => new Answer()
            {
                AssessmentAnswerId = assessmentAnswer.Id,
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


        public async Task<bool> IsAnswerIdExists(int id)
        {
            bool isAssessmentAnswerExists = await _dataContext.AssessmentAnswers.AsNoTracking().Where(x => x.AssessmentUserStatusId == id && x.IsActive).AnyAsync();

            return isAssessmentAnswerExists;
        }

        public async Task<bool> UpdateAnswer(AssessmentUserAnswerDTO assessmentUserAnswerDTO)
        {
            Entities.AssessmentAnswer assessmentAnswer =
                await _dataContext.AssessmentAnswers.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.AssessmentUserStatusId == assessmentUserAnswerDTO.AssessmentUserStatusId);

            if (assessmentAnswer != null)
            {
                assessmentAnswer.AssessmentUserStatusId = assessmentUserAnswerDTO.AssessmentUserStatusId;
                assessmentAnswer.TotalScore = assessmentUserAnswerDTO.TotalScore;
                assessmentAnswer.AnswersJson = assessmentUserAnswerDTO.AnswersJson;
                assessmentAnswer.DateManagerApproved = assessmentUserAnswerDTO.DateManagerApproved;
                assessmentAnswer.DateEmployeeApproved = assessmentUserAnswerDTO.DateEmployeeApproved;
                assessmentAnswer.ModifiedBy = assessmentUserAnswerDTO.ModifiedBy;
                assessmentAnswer.LanguageCode = assessmentUserAnswerDTO.LanguageCode;
                assessmentAnswer.ApproverTwwId = assessmentUserAnswerDTO.ApproverTwwId;
                assessmentAnswer.ShowEmpLevel = assessmentUserAnswerDTO.ShowEmpLevel;

                if (assessmentUserAnswerDTO.StatusId == (int)AssessmentState.Done)
                    assessmentAnswer.DateTimeSubmitted = DateTime.UtcNow;
                else
                    assessmentAnswer.DateTimeSubmitted = null;

                _dataContext.Entry(assessmentAnswer).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAnswer_v2(AssessmentUserAnswerDTO assessmentUserAnswerDTO)
        {
            Entities.AssessmentAnswer assessmentAnswer =
                await _dataContext.AssessmentAnswers.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.AssessmentUserStatusId == assessmentUserAnswerDTO.AssessmentUserStatusId);

            if (assessmentAnswer != null)
            {
                assessmentAnswer.AssessmentUserStatusId = assessmentUserAnswerDTO.AssessmentUserStatusId;
                assessmentAnswer.TotalScore = assessmentUserAnswerDTO.TotalScore;
                assessmentAnswer.AnswersJson = assessmentUserAnswerDTO.AnswersJson;
                assessmentAnswer.DateManagerApproved = assessmentUserAnswerDTO.DateManagerApproved;
                assessmentAnswer.DateEmployeeApproved = assessmentUserAnswerDTO.DateEmployeeApproved;
                assessmentAnswer.ModifiedBy = assessmentUserAnswerDTO.ModifiedBy;
                assessmentAnswer.LanguageCode = assessmentUserAnswerDTO.LanguageCode;
                assessmentAnswer.ApproverTwwId = assessmentUserAnswerDTO.ApproverTwwId;
                assessmentAnswer.ShowEmpLevel = assessmentUserAnswerDTO.ShowEmpLevel;

                if (assessmentUserAnswerDTO.StatusId == (int)AssessmentState.Done)
                    assessmentAnswer.DateTimeSubmitted = DateTime.UtcNow;
                else
                    assessmentAnswer.DateTimeSubmitted = null;

                _dataContext.Entry(assessmentAnswer).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                List<Entities.LookUpTables.Answer> getAnswers =
                     await _dataContext.Answers.AsNoTracking()
                            .Where(x => x.AssessmentAnswerId == assessmentAnswer.Id)
                            .ToListAsync();

                var forUpdates = (from answer in getAnswers
                                  join answerdto in assessmentUserAnswerDTO.Answers
                                      on answer.AssessmentAnswerId equals assessmentAnswer.Id
                                  where answerdto.CategoryCode == answer.CategoryCode
                                           && answerdto.QuestionCode == answer.QuestionCode
                                           && answerdto.DomId == answer.DomId
                                  select new
                                  {
                                      Id = answer.Id,
                                      AssessmentAnswerId = assessmentAnswer.Id,
                                      DomId = answerdto.DomId,
                                      CategoryCode = answerdto.CategoryCode,
                                      QuestionCode = answerdto.QuestionCode,
                                      AnswerText = answerdto.AnswerText,
                                      AnswerPoints = answer.Points,
                                      AnswerDTOPoints = answerdto.Points
                                  })
                                    .ToList();


                if (forUpdates.Any())
                {
                    List<Answer> finalAnswer = new List<Answer>();
                    IReadOnlyCollection<Answer> updateTextAnswers = forUpdates
                                                                    .Where(x => x.AnswerPoints == -1 && x.AnswerDTOPoints == -1) //-1 means the dom is not Radio
                                                                    .Select(x => new Answer()
                                                                    {
                                                                        Id = x.Id,
                                                                        AssessmentAnswerId = x.AssessmentAnswerId,
                                                                        DomId = x.DomId,
                                                                        CategoryCode = x.CategoryCode,
                                                                        QuestionCode = x.QuestionCode,
                                                                        AnswerText = x.AnswerText == string.Empty ? null : x.AnswerText,
                                                                        Points = x.AnswerDTOPoints
                                                                    }).ToList();


                    finalAnswer.AddRange(updateTextAnswers); // fill updated text area

                    IReadOnlyCollection<Answer> updateRadioSelection = forUpdates
                                                            .Where(x => x.AnswerPoints != -1 && x.AnswerDTOPoints != -1) //-1 means the dom is Radio
                                                            .Select(x => new Answer()
                                                            {
                                                                Id = x.Id,
                                                                AssessmentAnswerId = x.Id,
                                                                DomId = x.DomId,
                                                                CategoryCode = x.CategoryCode,
                                                                QuestionCode = x.QuestionCode,
                                                                AnswerText = x.AnswerText == string.Empty ? null : x.AnswerText,
                                                                Points = x.AnswerDTOPoints
                                                            }).ToList();



                    finalAnswer.AddRange(updateRadioSelection); //set new dom selection of radio and points

                    foreach (var ans in getAnswers)
                    {
                        foreach (var item in finalAnswer)
                        {
                            if (ans.CategoryCode == item.CategoryCode && ans.QuestionCode == item.QuestionCode && ans.DomId == item.DomId)
                            {
                                ans.DomId = item.DomId;
                                ans.AnswerText = item.AnswerText;
                                ans.Points = item.Points;
                            }
                        }
                    }

                    _dataContext.Answers.UpdateRange(getAnswers);
                    await _dataContext.SaveChangesAsync();

                }

                var getForUpdateIds = forUpdates.Select(x => x.Id);
                IReadOnlyCollection<Answer> forDeletes = getAnswers.Where(x => !getForUpdateIds.Contains(x.Id)).ToList();

                if (forDeletes.Any())
                    _dataContext.Answers.RemoveRange(forDeletes);


                var forInserts = assessmentUserAnswerDTO.Answers
                   .Where(r => !forUpdates.Any(a => a.CategoryCode == r.CategoryCode && a.QuestionCode == r.QuestionCode && a.DomId == r.DomId))
                   .ToList();

                if (forInserts.Any())
                {
                    var insertAnswers = forInserts.Select(x => new Answer()
                    {
                        AssessmentAnswerId = assessmentAnswer.Id,
                        DomId = x.DomId,
                        CategoryCode = x.CategoryCode,
                        QuestionCode = x.QuestionCode,
                        AnswerText = x.AnswerText == string.Empty ? null : x.AnswerText,
                        Points = x.Points
                    });

                    _dataContext.Answers.AddRange(insertAnswers);
                    await _dataContext.SaveChangesAsync();
                }
                return true;
            }

            return false;
        }

        public async Task<AssessmentAnswersModel> GetAnswers(int assessmentUserStatusId)
        {
            var result = await GetAssessmentAnswerByAssessmentUserStatus(assessmentUserStatusId);

            if (result == null)
                return null;

            return new AssessmentAnswersModel(
                result.AssessmentUserStatusId,
                result.TotalScore,
                result.DateManagerApproved,
                result.DateEmployeeApproved,
                result.LanguageCode,
                result.ApproverTwwId,
                result.DateTimeSubmitted,
                (result.Answers.Any() ?
                    result.Answers
                    .OrderBy(x => x.CategoryCode)
                    .Select(x => new
                                AnswersModel(x.Id, x.AssessmentAnswerId, x.DomId, x.CategoryCode, x.QuestionCode, x.AnswerText, x.Points))
                    .ToList()
                    : new List<AnswersModel>())
                );

        }

        public async Task<bool> DeleteAnswers(int[] answerIds)
        {

            var answersToRemove = _dataContext.Answers
                .Where(x => answerIds.Contains(x.Id))
                .AsNoTracking();

            _dataContext.Answers.RemoveRange(answersToRemove);
            int affectedRows = await _dataContext.SaveChangesAsync();

            return affectedRows >= 0;

        }

    }
}
