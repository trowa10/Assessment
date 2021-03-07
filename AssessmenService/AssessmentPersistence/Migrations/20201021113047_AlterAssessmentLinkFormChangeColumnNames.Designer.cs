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
    [Migration("20201021113047_AlterAssessmentLinkFormChangeColumnNames")]
    partial class AlterAssessmentLinkFormChangeColumnNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

                    b.Property<int>("TotalScore");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentUserStatusId");

                    b.ToTable("AssessmentAnswers");

                    b.HasData(
                        new { Id = 1, AnswersJson = "[{}]", ApproverTwwId = 0, AssessmentUserStatusId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 593, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), IsActive = true, ModifiedBy = 10146063, TotalScore = 0 }
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

                    b.HasKey("Id");

                    b.HasIndex("AssessmentCode");

                    b.HasIndex("TypeId");

                    b.ToTable("AssessmentTemplates");

                    b.HasData(
                        new { Id = 1, AssessmentCode = "PA2020", DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 590, DateTimeKind.Utc), EndDate = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), IsActive = true, ModifiedBy = 10146063, ScoreCriteriaId = 1, StartDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Performance Appraisal", TypeId = 1, Version = "1.0", Year = 2020 },
                        new { Id = 2, AssessmentCode = "SD2020", DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc), EndDate = new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), IsActive = true, ModifiedBy = 10146063, ScoreCriteriaId = 1, StartDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Salary Discussion", TypeId = 2, Version = "1.0", Year = 2020 }
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
                        new { Id = 1, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999996, StatusId = 2, UserId = 99999992, UserRegionId = 1, formChanged = false },
                        new { Id = 2, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999995, StatusId = 1, UserId = 99999991, UserRegionId = 2, formChanged = false },
                        new { Id = 3, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 1111110, StatusId = 1, UserId = 99999999, UserRegionId = 1, formChanged = false },
                        new { Id = 4, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 2, UserId = 99999998, UserRegionId = 1, formChanged = false },
                        new { Id = 5, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 1, UserId = 99999997, UserRegionId = 2, formChanged = false },
                        new { Id = 6, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 0, UserId = 99999996, UserRegionId = 1, formChanged = false },
                        new { Id = 7, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 1, UserId = 99999995, UserRegionId = 2, formChanged = false },
                        new { Id = 8, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 2, UserId = 99999993, UserRegionId = 1, formChanged = false },
                        new { Id = 9, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999999, StatusId = 0, UserId = 99999994, UserRegionId = 1, formChanged = false },
                        new { Id = 10, AssessmentTemplateId = 1, DateCreated = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), DateModified = new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), EmployeeLevelId = 1, IsActive = true, LockedToUserId = 0, ModifiedBy = 10146063, ReportsTo = 99999996, StatusId = 1, UserId = 99999990, UserRegionId = 2, formChanged = false }
                    );
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.Assessment", b =>
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
                        .HasDefaultValue(new DateTime(2020, 10, 21, 11, 30, 46, 611, DateTimeKind.Utc));

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
                    b.HasOne("AssessmentPersistence.Entities.LookUpTables.Assessment", "Assessment")
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

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.AssessmentUserComment", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentUserStatus", "AssessmentUserStatus")
                        .WithMany("AssessmentUserComments")
                        .HasForeignKey("AssessmentUserStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssessmentPersistence.Entities.LookUpTables.TemplatePermission", b =>
                {
                    b.HasOne("AssessmentPersistence.Entities.AssessmentTemplate", "AssessmentTemplate")
                        .WithMany("TemplatePermissions")
                        .HasForeignKey("AssessmentTemplateId")
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