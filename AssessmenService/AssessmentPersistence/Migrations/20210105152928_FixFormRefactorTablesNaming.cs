using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class FixFormRefactorTablesNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_AssessmentAnswers_AssessmentAnswerId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Category_CategoryCode",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Dom_DomId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDom_Category_CategoryCode",
                table: "CategoryDom");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDom_Dom_DomId",
                table: "CategoryDom");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDomTranslation_CategoryDom_CategoryDomId",
                table: "CategoryDomTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDomTranslation_Translation_TranslationId",
                table: "CategoryDomTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_Dom_DomElement_ElementId",
                table: "Dom");

            migrationBuilder.DropForeignKey(
                name: "FK_Dom_DomType_TypeId",
                table: "Dom");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_Category_CategoryCode",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDom_Dom_DomId",
                table: "QuestionnaireDom");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDom_Questionnaire_QuestionnaireId",
                table: "QuestionnaireDom");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDomTranslation_QuestionnaireDom_QuestionnaireDo~",
                table: "QuestionnaireDomTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDomTranslation_Translation_TranslationId",
                table: "QuestionnaireDomTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrder_AssessmentTemplates_AssessmentTemplate~",
                table: "TemplateCategoryOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrder_Category_CategoryCode",
                table: "TemplateCategoryOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateQuestionnaire_AssessmentTemplates_AssessmentTemplate~",
                table: "TemplateQuestionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateQuestionnaire_Questionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translation",
                table: "Translation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateQuestionnaire",
                table: "TemplateQuestionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateCategoryOrder",
                table: "TemplateCategoryOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionnaireDomTranslation",
                table: "QuestionnaireDomTranslation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionnaireDom",
                table: "QuestionnaireDom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DomType",
                table: "DomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DomElement",
                table: "DomElement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dom",
                table: "Dom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDomTranslation",
                table: "CategoryDomTranslation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDom",
                table: "CategoryDom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "Translation",
                newName: "Translations");

            migrationBuilder.RenameTable(
                name: "TemplateQuestionnaire",
                newName: "TemplateQuestionnaires");

            migrationBuilder.RenameTable(
                name: "TemplateCategoryOrder",
                newName: "TemplateCategoryOrders");

            migrationBuilder.RenameTable(
                name: "QuestionnaireDomTranslation",
                newName: "QuestionnaireDomTranslations");

            migrationBuilder.RenameTable(
                name: "QuestionnaireDom",
                newName: "QuestionnaireDoms");

            migrationBuilder.RenameTable(
                name: "Questionnaire",
                newName: "Questionnaires");

            migrationBuilder.RenameTable(
                name: "DomType",
                newName: "DomTypes");

            migrationBuilder.RenameTable(
                name: "DomElement",
                newName: "DomElements");

            migrationBuilder.RenameTable(
                name: "Dom",
                newName: "Doms");

            migrationBuilder.RenameTable(
                name: "CategoryDomTranslation",
                newName: "CategoryDomTranslations");

            migrationBuilder.RenameTable(
                name: "CategoryDom",
                newName: "CategoryDoms");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateQuestionnaire_QuestionnaireId",
                table: "TemplateQuestionnaires",
                newName: "IX_TemplateQuestionnaires_QuestionnaireId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateQuestionnaire_AssessmentTemplateId",
                table: "TemplateQuestionnaires",
                newName: "IX_TemplateQuestionnaires_AssessmentTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateCategoryOrder_CategoryCode",
                table: "TemplateCategoryOrders",
                newName: "IX_TemplateCategoryOrders_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateCategoryOrder_AssessmentTemplateId",
                table: "TemplateCategoryOrders",
                newName: "IX_TemplateCategoryOrders_AssessmentTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDomTranslation_TranslationId",
                table: "QuestionnaireDomTranslations",
                newName: "IX_QuestionnaireDomTranslations_TranslationId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDomTranslation_QuestionnaireDomId",
                table: "QuestionnaireDomTranslations",
                newName: "IX_QuestionnaireDomTranslations_QuestionnaireDomId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDom_QuestionnaireId",
                table: "QuestionnaireDoms",
                newName: "IX_QuestionnaireDoms_QuestionnaireId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDom_DomId",
                table: "QuestionnaireDoms",
                newName: "IX_QuestionnaireDoms_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaire_CategoryCode",
                table: "Questionnaires",
                newName: "IX_Questionnaires_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Dom_TypeId",
                table: "Doms",
                newName: "IX_Doms_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dom_ElementId",
                table: "Doms",
                newName: "IX_Doms_ElementId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDomTranslation_TranslationId",
                table: "CategoryDomTranslations",
                newName: "IX_CategoryDomTranslations_TranslationId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDomTranslation_CategoryDomId",
                table: "CategoryDomTranslations",
                newName: "IX_CategoryDomTranslations_CategoryDomId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDom_DomId",
                table: "CategoryDoms",
                newName: "IX_CategoryDoms_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDom_CategoryCode",
                table: "CategoryDoms",
                newName: "IX_CategoryDoms_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_DomId",
                table: "Answers",
                newName: "IX_Answers_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_CategoryCode",
                table: "Answers",
                newName: "IX_Answers_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_AssessmentAnswerId",
                table: "Answers",
                newName: "IX_Answers_AssessmentAnswerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 5, 15, 29, 28, 225, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 4, 14, 21, 48, 630, DateTimeKind.Utc));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translations",
                table: "Translations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateQuestionnaires",
                table: "TemplateQuestionnaires",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateCategoryOrders",
                table: "TemplateCategoryOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionnaireDomTranslations",
                table: "QuestionnaireDomTranslations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionnaireDoms",
                table: "QuestionnaireDoms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DomTypes",
                table: "DomTypes",
                column: "TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DomElements",
                table: "DomElements",
                column: "ElementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doms",
                table: "Doms",
                column: "DomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDomTranslations",
                table: "CategoryDomTranslations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDoms",
                table: "CategoryDoms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 216, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AssessmentAnswers_AssessmentAnswerId",
                table: "Answers",
                column: "AssessmentAnswerId",
                principalTable: "AssessmentAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Categories_CategoryCode",
                table: "Answers",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Doms_DomId",
                table: "Answers",
                column: "DomId",
                principalTable: "Doms",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDoms_Categories_CategoryCode",
                table: "CategoryDoms",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDoms_Doms_DomId",
                table: "CategoryDoms",
                column: "DomId",
                principalTable: "Doms",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDomTranslations_CategoryDoms_CategoryDomId",
                table: "CategoryDomTranslations",
                column: "CategoryDomId",
                principalTable: "CategoryDoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDomTranslations_Translations_TranslationId",
                table: "CategoryDomTranslations",
                column: "TranslationId",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doms_DomElements_ElementId",
                table: "Doms",
                column: "ElementId",
                principalTable: "DomElements",
                principalColumn: "ElementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doms_DomTypes_TypeId",
                table: "Doms",
                column: "TypeId",
                principalTable: "DomTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDoms_Doms_DomId",
                table: "QuestionnaireDoms",
                column: "DomId",
                principalTable: "Doms",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDoms_Questionnaires_QuestionnaireId",
                table: "QuestionnaireDoms",
                column: "QuestionnaireId",
                principalTable: "Questionnaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDomTranslations_QuestionnaireDoms_Questionnaire~",
                table: "QuestionnaireDomTranslations",
                column: "QuestionnaireDomId",
                principalTable: "QuestionnaireDoms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDomTranslations_Translations_TranslationId",
                table: "QuestionnaireDomTranslations",
                column: "TranslationId",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Categories_CategoryCode",
                table: "Questionnaires",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrders_AssessmentTemplates_AssessmentTemplat~",
                table: "TemplateCategoryOrders",
                column: "AssessmentTemplateId",
                principalTable: "AssessmentTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrders_Categories_CategoryCode",
                table: "TemplateCategoryOrders",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateQuestionnaires_AssessmentTemplates_AssessmentTemplat~",
                table: "TemplateQuestionnaires",
                column: "AssessmentTemplateId",
                principalTable: "AssessmentTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateQuestionnaires_Questionnaires_QuestionnaireId",
                table: "TemplateQuestionnaires",
                column: "QuestionnaireId",
                principalTable: "Questionnaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AssessmentAnswers_AssessmentAnswerId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Categories_CategoryCode",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Doms_DomId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDoms_Categories_CategoryCode",
                table: "CategoryDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDoms_Doms_DomId",
                table: "CategoryDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDomTranslations_CategoryDoms_CategoryDomId",
                table: "CategoryDomTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDomTranslations_Translations_TranslationId",
                table: "CategoryDomTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_Doms_DomElements_ElementId",
                table: "Doms");

            migrationBuilder.DropForeignKey(
                name: "FK_Doms_DomTypes_TypeId",
                table: "Doms");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDoms_Doms_DomId",
                table: "QuestionnaireDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDoms_Questionnaires_QuestionnaireId",
                table: "QuestionnaireDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDomTranslations_QuestionnaireDoms_Questionnaire~",
                table: "QuestionnaireDomTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionnaireDomTranslations_Translations_TranslationId",
                table: "QuestionnaireDomTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Categories_CategoryCode",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrders_AssessmentTemplates_AssessmentTemplat~",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrders_Categories_CategoryCode",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateQuestionnaires_AssessmentTemplates_AssessmentTemplat~",
                table: "TemplateQuestionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateQuestionnaires_Questionnaires_QuestionnaireId",
                table: "TemplateQuestionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translations",
                table: "Translations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateQuestionnaires",
                table: "TemplateQuestionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateCategoryOrders",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questionnaires",
                table: "Questionnaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionnaireDomTranslations",
                table: "QuestionnaireDomTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionnaireDoms",
                table: "QuestionnaireDoms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DomTypes",
                table: "DomTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doms",
                table: "Doms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DomElements",
                table: "DomElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDomTranslations",
                table: "CategoryDomTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryDoms",
                table: "CategoryDoms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Translations",
                newName: "Translation");

            migrationBuilder.RenameTable(
                name: "TemplateQuestionnaires",
                newName: "TemplateQuestionnaire");

            migrationBuilder.RenameTable(
                name: "TemplateCategoryOrders",
                newName: "TemplateCategoryOrder");

            migrationBuilder.RenameTable(
                name: "Questionnaires",
                newName: "Questionnaire");

            migrationBuilder.RenameTable(
                name: "QuestionnaireDomTranslations",
                newName: "QuestionnaireDomTranslation");

            migrationBuilder.RenameTable(
                name: "QuestionnaireDoms",
                newName: "QuestionnaireDom");

            migrationBuilder.RenameTable(
                name: "DomTypes",
                newName: "DomType");

            migrationBuilder.RenameTable(
                name: "Doms",
                newName: "Dom");

            migrationBuilder.RenameTable(
                name: "DomElements",
                newName: "DomElement");

            migrationBuilder.RenameTable(
                name: "CategoryDomTranslations",
                newName: "CategoryDomTranslation");

            migrationBuilder.RenameTable(
                name: "CategoryDoms",
                newName: "CategoryDom");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateQuestionnaires_QuestionnaireId",
                table: "TemplateQuestionnaire",
                newName: "IX_TemplateQuestionnaire_QuestionnaireId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateQuestionnaires_AssessmentTemplateId",
                table: "TemplateQuestionnaire",
                newName: "IX_TemplateQuestionnaire_AssessmentTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateCategoryOrders_CategoryCode",
                table: "TemplateCategoryOrder",
                newName: "IX_TemplateCategoryOrder_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateCategoryOrders_AssessmentTemplateId",
                table: "TemplateCategoryOrder",
                newName: "IX_TemplateCategoryOrder_AssessmentTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_Questionnaires_CategoryCode",
                table: "Questionnaire",
                newName: "IX_Questionnaire_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDomTranslations_TranslationId",
                table: "QuestionnaireDomTranslation",
                newName: "IX_QuestionnaireDomTranslation_TranslationId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDomTranslations_QuestionnaireDomId",
                table: "QuestionnaireDomTranslation",
                newName: "IX_QuestionnaireDomTranslation_QuestionnaireDomId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDoms_QuestionnaireId",
                table: "QuestionnaireDom",
                newName: "IX_QuestionnaireDom_QuestionnaireId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionnaireDoms_DomId",
                table: "QuestionnaireDom",
                newName: "IX_QuestionnaireDom_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_Doms_TypeId",
                table: "Dom",
                newName: "IX_Dom_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Doms_ElementId",
                table: "Dom",
                newName: "IX_Dom_ElementId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDomTranslations_TranslationId",
                table: "CategoryDomTranslation",
                newName: "IX_CategoryDomTranslation_TranslationId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDomTranslations_CategoryDomId",
                table: "CategoryDomTranslation",
                newName: "IX_CategoryDomTranslation_CategoryDomId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDoms_DomId",
                table: "CategoryDom",
                newName: "IX_CategoryDom_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryDoms_CategoryCode",
                table: "CategoryDom",
                newName: "IX_CategoryDom_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_DomId",
                table: "Answer",
                newName: "IX_Answer_DomId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_CategoryCode",
                table: "Answer",
                newName: "IX_Answer_CategoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_AssessmentAnswerId",
                table: "Answer",
                newName: "IX_Answer_AssessmentAnswerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 4, 14, 21, 48, 630, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 5, 15, 29, 28, 225, DateTimeKind.Utc));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translation",
                table: "Translation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateQuestionnaire",
                table: "TemplateQuestionnaire",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateCategoryOrder",
                table: "TemplateCategoryOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questionnaire",
                table: "Questionnaire",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionnaireDomTranslation",
                table: "QuestionnaireDomTranslation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionnaireDom",
                table: "QuestionnaireDom",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DomType",
                table: "DomType",
                column: "TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dom",
                table: "Dom",
                column: "DomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DomElement",
                table: "DomElement",
                column: "ElementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDomTranslation",
                table: "CategoryDomTranslation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryDom",
                table: "CategoryDom",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 623, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 623, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_AssessmentAnswers_AssessmentAnswerId",
                table: "Answer",
                column: "AssessmentAnswerId",
                principalTable: "AssessmentAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Category_CategoryCode",
                table: "Answer",
                column: "CategoryCode",
                principalTable: "Category",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Dom_DomId",
                table: "Answer",
                column: "DomId",
                principalTable: "Dom",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDom_Category_CategoryCode",
                table: "CategoryDom",
                column: "CategoryCode",
                principalTable: "Category",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDom_Dom_DomId",
                table: "CategoryDom",
                column: "DomId",
                principalTable: "Dom",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDomTranslation_CategoryDom_CategoryDomId",
                table: "CategoryDomTranslation",
                column: "CategoryDomId",
                principalTable: "CategoryDom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDomTranslation_Translation_TranslationId",
                table: "CategoryDomTranslation",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dom_DomElement_ElementId",
                table: "Dom",
                column: "ElementId",
                principalTable: "DomElement",
                principalColumn: "ElementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dom_DomType_TypeId",
                table: "Dom",
                column: "TypeId",
                principalTable: "DomType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_Category_CategoryCode",
                table: "Questionnaire",
                column: "CategoryCode",
                principalTable: "Category",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDom_Dom_DomId",
                table: "QuestionnaireDom",
                column: "DomId",
                principalTable: "Dom",
                principalColumn: "DomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDom_Questionnaire_QuestionnaireId",
                table: "QuestionnaireDom",
                column: "QuestionnaireId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDomTranslation_QuestionnaireDom_QuestionnaireDo~",
                table: "QuestionnaireDomTranslation",
                column: "QuestionnaireDomId",
                principalTable: "QuestionnaireDom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionnaireDomTranslation_Translation_TranslationId",
                table: "QuestionnaireDomTranslation",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrder_AssessmentTemplates_AssessmentTemplate~",
                table: "TemplateCategoryOrder",
                column: "AssessmentTemplateId",
                principalTable: "AssessmentTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrder_Category_CategoryCode",
                table: "TemplateCategoryOrder",
                column: "CategoryCode",
                principalTable: "Category",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateQuestionnaire_AssessmentTemplates_AssessmentTemplate~",
                table: "TemplateQuestionnaire",
                column: "AssessmentTemplateId",
                principalTable: "AssessmentTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateQuestionnaire_Questionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire",
                column: "QuestionnaireId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
