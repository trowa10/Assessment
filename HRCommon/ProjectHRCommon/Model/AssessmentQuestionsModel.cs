using ProjectHRCommon.Model.QuestionnaireModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHRCommon.Model
{
    public class AssessmentQuestionsModel
    {
        private readonly int _templateId;
        private readonly string _title;
        private readonly string _questionsJson;
        private readonly QuestionnaireTemplateModel[] _questionnaireModel;
        private readonly bool _isAvailable;

        //Old using Question Json
        public AssessmentQuestionsModel(int templateId, string title, string questionsJson, bool isAvailable)
        {
            _templateId = templateId;
            _title = title;
            _questionsJson = questionsJson;
            _isAvailable = isAvailable;
        }

        //New Using new tables
        public AssessmentQuestionsModel(int templateId, string title, QuestionnaireTemplateModel[] questionnaireModel, bool isAvailable)
        {
            _templateId = templateId;
            _title = title;
            _questionnaireModel = questionnaireModel;
            _isAvailable = isAvailable;
        }

        public int TemplateId => _templateId;

        public string Title => _title;

        public string QuestionsJson => _questionsJson;

        public QuestionnaireTemplateModel[] QuestionnaireModel => _questionnaireModel;

        public bool IsAvailable => _isAvailable;

    }
}
