﻿// <auto-generated />
using System;
using AssessmentPersistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssessmentPersistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210105152928_FixFormRefactorTablesNaming")]
    partial class FixFormRefactorTablesNaming
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AssessmentPersistence.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssessmentCode")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Assessments");

                    b.HasData(
                        new { Id = 1, AssessmentCode = "PA2020", Name = "Performance Appraisal 2020" },
                        new { Id = 2, AssessmentCode = "SD2020", Name = "Salary Discussion 2020" }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswersJson");

                    b.Property<int>("ApproverTwwId");

                    b.Property<int>("AssessmentUserStatusId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateEmployeeApproved");

                    b.Property<DateTime?>("DateManagerApproved");

                    b.Property<DateTime>("DateModified");

                    b.Property<DateTime?>("DateTimeSubmitted");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LanguageCode");

                    b.Property<int>("ModifiedBy");

                    b.Property<bool?>("ShowEmpLevel");

                    b.Property<int>("TotalScore");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentUserStatusId");

                    b.ToTable("AssessmentAnswers");

                    b.HasData(
                        new { Id = 1, AnswersJson = "[{}]", ApproverTwwId = 0, AssessmentUserStatusId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), IsActive = true, ModifiedBy = 10146063, TotalScore = 0 }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentQuestionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentTemplateId");

                    b.Property<int>("TranslationQuestionnaireId");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTemplateId");

                    b.HasIndex("TranslationQuestionnaireId");

                    b.ToTable("AssessmentQuestionnaires");

                    b.HasData(
                        new { Id = 1, AssessmentTemplateId = 1, TranslationQuestionnaireId = 1 },
                        new { Id = 2, AssessmentTemplateId = 1, TranslationQuestionnaireId = 2 },
                        new { Id = 3, AssessmentTemplateId = 2, TranslationQuestionnaireId = 1 },
                        new { Id = 4, AssessmentTemplateId = 2, TranslationQuestionnaireId = 2 }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Max");

                    b.Property<int>("Min");

                    b.Property<string>("Name");

                    b.Property<int>("ScoreCriteriaId");

                    b.HasKey("Id");

                    b.ToTable("AssessmentScore");

                    b.HasData(
                        new { Id = 1, Max = 13, Min = 0, Name = "Developer", ScoreCriteriaId = 1 },
                        new { Id = 2, Max = 31, Min = 14, Name = "Performer", ScoreCriteriaId = 1 },
                        new { Id = 3, Max = 39, Min = 32, Name = "Outstanding", ScoreCriteriaId = 1 },
                        new { Id = 4, Max = 15, Min = 0, Name = "Developer", ScoreCriteriaId = 2 },
                        new { Id = 5, Max = 36, Min = 16, Name = "Performer", ScoreCriteriaId = 2 },
                        new { Id = 6, Max = 45, Min = 37, Name = "Outstanding", ScoreCriteriaId = 2 },
                        new { Id = 7, Max = -1, Min = -1, Name = "N/A", ScoreCriteriaId = 1 },
                        new { Id = 8, Max = -1, Min = -1, Name = "N/A", ScoreCriteriaId = 2 }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssessmentCode");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<int>("ScoreCriteriaId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.Property<int>("TypeId");

                    b.Property<string>("Version");

                    b.Property<int>("Year");

                    b.Property<bool>("isStash");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentCode");

                    b.HasIndex("TypeId");

                    b.ToTable("AssessmentTemplates");

                    b.HasData(
                        new { Id = 1, AssessmentCode = "PA2020", DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 216, DateTimeKind.Utc), EndDate = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), IsActive = true, ModifiedBy = 10146063, ScoreCriteriaId = 1, StartDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Performance Appraisal", TypeId = 1, Version = "1.0", Year = 2020, isStash = false },
                        new { Id = 2, AssessmentCode = "SD2020", DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EndDate = new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), IsActive = true, ModifiedBy = 10146063, ScoreCriteriaId = 1, StartDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Salary Discussion", TypeId = 2, Version = "1.0", Year = 2020, isStash = false }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentUserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentTemplateId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("EmployeeLevelId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LockedToUserId");

                    b.Property<int>("ModifiedBy");

                    b.Property<string>("Pin");

                    b.Property<int>("ReportsTo");

                    b.Property<string>("SiteCode");

                    b.Property<int>("StatusId");

                    b.Property<int>("UserId");

                    b.Property<int>("UserRegionId");

                    b.Property<bool>("formChanged")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTemplateId");

                    b.HasIndex("EmployeeLevelId");

                    b.ToTable("AssessmentUserStatus");

                    b.HasData(
                        new { Id = 1, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999996, StatusId = 2, UserId = 99999992, UserRegionId = 1, formChanged = false },
                        new { Id = 2, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999995, StatusId = 1, UserId = 99999991, UserRegionId = 2, formChanged = false },
                        new { Id = 3, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 1111110, StatusId = 1, UserId = 99999999, UserRegionId = 1, formChanged = false },
                        new { Id = 4, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 2, UserId = 99999998, UserRegionId = 1, formChanged = false },
                        new { Id = 5, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 1, UserId = 99999997, UserRegionId = 2, formChanged = false },
                        new { Id = 6, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 0, UserId = 99999996, UserRegionId = 1, formChanged = false },
                        new { Id = 7, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 1, UserId = 99999995, UserRegionId = 2, formChanged = false },
                        new { Id = 8, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 2, UserId = 99999993, UserRegionId = 1, formChanged = false },
                        new { Id = 9, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 0, UserId = 99999994, UserRegionId = 1, formChanged = false },
                        new { Id = 10, AssessmentTemplateId = 1, DateCreated = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), DateModified = new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999996, StatusId = 1, UserId = 99999990, UserRegionId = 2, formChanged = false }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerText");

                    b.Property<int>("AssessmentAnswerId");

                    b.Property<string>("CategoryCode");

                    b.Property<DateTime>("DateTimeCreatedUtc");

                    b.Property<int>("DomId");

                    b.Property<int>("Points");

                    b.Property<string>("QuestionCode");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentAnswerId");

                    b.HasIndex("CategoryCode");

                    b.HasIndex("DomId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.AssessmentFormType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssessmentFormTypes");

                    b.HasData(
                        new { Id = 1, Name = "Performance Appraisal" },
                        new { Id = 2, Name = "Salary Discussion" }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.AssessmentLinkForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentUserstatusId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2021, 1, 5, 15, 29, 28, 225, DateTimeKind.Utc));

                    b.Property<int>("LinkedAssessmentUserstatusId");

                    b.HasKey("Id");

                    b.ToTable("AssessmentLinkForms");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.AssessmentUserComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentUserStatusId");

                    b.Property<string>("CategoryCode");

                    b.Property<string>("Comments");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<bool>("IsEdited");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TwwId");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentUserStatusId");

                    b.ToTable("AssessmentUserComments");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Category", b =>
                {
                    b.Property<string>("CategoryCode")
                        .ValueGeneratedOnAdd();

                    b.HasKey("CategoryCode");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.CategoryDom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryCode");

                    b.Property<double>("CategoryDomOrder");

                    b.Property<DateTime>("DateTimeUtc");

                    b.Property<int>("DomId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryCode");

                    b.HasIndex("DomId");

                    b.ToTable("CategoryDoms");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.CategoryDomTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryDomId");

                    b.Property<int>("TranslationId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryDomId");

                    b.HasIndex("TranslationId");

                    b.ToTable("CategoryDomTranslations");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Dom", b =>
                {
                    b.Property<int>("DomId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataType");

                    b.Property<DateTime>("DateTimeUtc");

                    b.Property<int>("ElementId");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("ForAnswer");

                    b.Property<string>("Group");

                    b.Property<string>("Id");

                    b.Property<bool>("IsRequired");

                    b.Property<string>("Name");

                    b.Property<string>("PlaceHolder");

                    b.Property<string>("Style");

                    b.Property<int>("TableRow");

                    b.Property<int>("TypeId");

                    b.Property<string>("Value");

                    b.HasKey("DomId");

                    b.HasIndex("ElementId");

                    b.HasIndex("TypeId");

                    b.ToTable("Doms");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.DomElement", b =>
                {
                    b.Property<int>("ElementId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ElementId");

                    b.ToTable("DomElements");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.DomType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TypeId");

                    b.ToTable("DomTypes");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new { Id = 1, Code = "en", Description = "English" },
                        new { Id = 2, Code = "sv", Description = "Swedish" }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Questionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryCode");

                    b.Property<string>("QuestionCode");

                    b.HasKey("Id");

                    b.HasIndex("CategoryCode");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.QuestionnaireDom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeUtc");

                    b.Property<int>("DomId");

                    b.Property<double>("QuestionnaireDomOrder");

                    b.Property<int>("QuestionnaireId");

                    b.HasKey("Id");

                    b.HasIndex("DomId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("QuestionnaireDoms");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.QuestionnaireDomTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionnaireDomId");

                    b.Property<int>("TranslationId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionnaireDomId");

                    b.HasIndex("TranslationId");

                    b.ToTable("QuestionnaireDomTranslations");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.ScoreCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ScoreCriterias");

                    b.HasData(
                        new { Id = 1, Description = "Manager" },
                        new { Id = 2, Description = "Employee" }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplateCategoryOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentTemplateId");

                    b.Property<string>("CategoryCode");

                    b.Property<double>("CategoryOrder");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTemplateId");

                    b.HasIndex("CategoryCode");

                    b.ToTable("TemplateCategoryOrders");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplatePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentTemplateId");

                    b.Property<int>("PermissionId");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTemplateId");

                    b.HasIndex("PermissionId");

                    b.ToTable("TemplatePermissions");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplateQuestionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssessmentTemplateId");

                    b.Property<int>("QuestionnaireId");

                    b.Property<double>("QuestionnaireOrder");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentTemplateId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("TemplateQuestionnaires");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LanguageCode");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TranslationQuestionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LanguageId");

                    b.Property<string>("QuestionsJson");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("TranslationQuestionnaires");

                    b.HasData(
                        new { Id = 1, LanguageId = 1, QuestionsJson = "[{}]" },
                        new { Id = 2, LanguageId = 2, QuestionsJson = "[{}]" },
                        new { Id = 3, LanguageId = 1, QuestionsJson = "[{}]" },
                        new { Id = 4, LanguageId = 2, QuestionsJson = "[{}]" }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentAnswer", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentUserStatus", "AssessmentUserStatus")
                        .WithMany()
                        .HasForeignKey("AssessmentUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentQuestionnaire", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "assessmentTemplate")
                        .WithMany()
                        .HasForeignKey("AssessmentTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.TranslationQuestionnaire", "translationQuestionnaire")
                        .WithMany()
                        .HasForeignKey("TranslationQuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentTemplate", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.Assessment", "Assessment")
                        .WithMany("AssessmentTemplates")
                        .HasForeignKey("AssessmentCode")
                        .HasPrincipalKey("AssessmentCode");

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.AssessmentFormType", "AssessmentFormType")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.AssessmentUserStatus", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "AssessmentTemplate")
                        .WithMany()
                        .HasForeignKey("AssessmentTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.AssessmentScore", "AssessmentScore")
                        .WithMany()
                        .HasForeignKey("EmployeeLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Answer", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentAnswer", "AssessmentAnswer")
                        .WithMany("Answers")
                        .HasForeignKey("AssessmentAnswerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryCode");

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Dom", "Dom")
                        .WithMany()
                        .HasForeignKey("DomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.AssessmentUserComment", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentUserStatus", "AssessmentUserStatus")
                        .WithMany("AssessmentUserComments")
                        .HasForeignKey("AssessmentUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.CategoryDom", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Category", "Category")
                        .WithMany("CategoryDoms")
                        .HasForeignKey("CategoryCode");

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Dom", "Dom")
                        .WithMany("CategoryDoms")
                        .HasForeignKey("DomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.CategoryDomTranslation", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.CategoryDom", "CategoryDom")
                        .WithMany("CategoryDomTranslations")
                        .HasForeignKey("CategoryDomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Translation", "Translation")
                        .WithMany()
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Dom", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.DomElement", "DomElement")
                        .WithMany("Doms")
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.DomType", "DomType")
                        .WithMany("Doms")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Questionnaire", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Category", "Category")
                        .WithMany("Questionnaires")
                        .HasForeignKey("CategoryCode");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.QuestionnaireDom", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Dom", "Dom")
                        .WithMany("QuestionnaireDoms")
                        .HasForeignKey("DomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Questionnaire", "Questionnaire")
                        .WithMany("QuestionnaireDoms")
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.QuestionnaireDomTranslation", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.QuestionnaireDom", "QuestionnaireDom")
                        .WithMany("QuestionnaireDomTranslations")
                        .HasForeignKey("QuestionnaireDomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Translation", "Translation")
                        .WithMany()
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplateCategoryOrder", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "AssessmentTemplate")
                        .WithMany("TemplateCategoryOrders")
                        .HasForeignKey("AssessmentTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryCode");
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplatePermission", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "AssessmentTemplate")
                        .WithMany("TemplatePermissions")
                        .HasForeignKey("AssessmentTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplateQuestionnaire", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "AssessmentTemplate")
                        .WithMany("TemplateQuestionnaires")
                        .HasForeignKey("AssessmentTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Questionnaire", "Questionnaire")
                        .WithMany("TemplateQuestionnaires")
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TranslationQuestionnaire", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
