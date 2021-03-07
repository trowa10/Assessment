using AssessmentPersistence.Entities;
using AssessmentPersistence.Entities.LookUpTables;
using Microsoft.EntityFrameworkCore;
using enumm = ProjectHRCommon.Enum;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AssessmentPersistence.Abstract;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class DataContext : DbContext
    {
        //set dbsets to virtual so mock can override

        public DataContext() { } //parameterless constructor for mocking in unit test
        public DataContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<AssessmentTemplate> AssessmentTemplates { get; set; }
        public virtual DbSet<AssessmentUserStatus> AssessmentUserStatus { get; set; }
        public virtual DbSet<AssessmentAnswer> AssessmentAnswers { get; set; }
        public virtual DbSet<AssessmentScore> AssessmentScore { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<TranslationQuestionnaire> TranslationQuestionnaires { get; set; }
        public virtual DbSet<AssessmentQuestionnaire> AssessmentQuestionnaires { get; set; }
        public virtual DbSet<TemplatePermission> TemplatePermissions { get; set; }
        public virtual DbSet<ScoreCriteria> ScoreCriterias { get; set; }
        public virtual DbSet<AssessmentFormType> AssessmentFormTypes { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<AssessmentUserComment> AssessmentUserComments { get; set; }
        public virtual DbSet<AssessmentLinkForm> AssessmentLinkForms { get; set; }
        public virtual DbSet<DomElement> DomElements { get; set; }
        public virtual DbSet<DomType> DomTypes { get; set; }
        public virtual DbSet<Dom> Doms { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<TemplateCategoryOrder> TemplateCategoryOrders { get; set; }
        public virtual DbSet<CategoryDom> CategoryDoms { get; set; }
        public virtual DbSet<CategoryDomTranslation> CategoryDomTranslations { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<TemplateQuestionnaire> TemplateQuestionnaires { get; set; }
        public virtual DbSet<QuestionnaireDom> QuestionnaireDoms { get; set; }
        public virtual DbSet<QuestionnaireDomTranslation> QuestionnaireDomTranslations { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AssessmentCategory> AssessmentCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssessmentFormType>()
               .HasData(
                new AssessmentFormType
                {
                    Id = 1,
                    Name = "Performance Appraisal"                   
                },
                new AssessmentFormType
                {
                    Id = 2,
                    Name = "Salary Discussion"
                }
            );

            modelBuilder.Entity<AssessmentTemplate>()
                .HasData(
                new AssessmentTemplate
                {
                    Id = 1,
                    Title = "Performance Appraisal",
                    Year = 2020,
                    Version = "1.0",
                    ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee,
                    StartDate = new DateTime(2020, 5, 1),
                    EndDate = new DateTime(2020, 10, 1),
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true,
                    AssessmentCode = "PA2020",
                    TypeId = 1
                },
                new AssessmentTemplate
                {
                    Id = 2,
                    Title = "Salary Discussion",
                    Year = 2020,
                    Version = "1.0",
                    ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee,
                    StartDate = new DateTime(2020, 11, 1),
                    EndDate = new DateTime(2020, 10, 31),
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true,
                    AssessmentCode = "SD2020",
                    TypeId = 2
                });



            modelBuilder.Entity<AssessmentUserStatus>()
               .HasData(
                new AssessmentUserStatus
                {
                    Id = 1,
                    UserId = 99999992,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 2,
                    ReportsTo = 99999996,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 2,
                    UserId = 99999991,
                    AssessmentTemplateId = 1,
                    UserRegionId = 2,
                    StatusId = 1,
                    ReportsTo = 99999995,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 3,
                    UserId = 99999999,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 1,
                    ReportsTo = 1111110,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 4,
                    UserId = 99999998,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 2,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 5,
                    UserId = 99999997,
                    AssessmentTemplateId = 1,
                    UserRegionId = 2,
                    StatusId = 1,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 6,
                    UserId = 99999996,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 0,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 7,
                    UserId = 99999995,
                    AssessmentTemplateId = 1,
                    UserRegionId = 2,
                    StatusId = 1,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 8,
                    UserId = 99999993,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 2,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 9,
                    UserId = 99999994,
                    AssessmentTemplateId = 1,
                    UserRegionId = 1,
                    StatusId = 0,
                    ReportsTo = 99999999,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                },
                new AssessmentUserStatus
                {
                    Id = 10,
                    UserId = 99999990,
                    AssessmentTemplateId = 1,
                    UserRegionId = 2,
                    StatusId = 1,
                    ReportsTo = 99999996,
                    EmployeeLevelId = 1,
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                }
            );

            modelBuilder.Entity<AssessmentAnswer>()
             .HasData(
                new AssessmentAnswer
                {
                    Id = 1,
                    AssessmentUserStatusId = 1,
                    AnswersJson = "[{}]",
                    DateCreated = DateTime.UtcNow,
                    ModifiedBy = 10146063,
                    IsActive = true
                });

            modelBuilder.Entity<AssessmentScore>()
               .HasData(new AssessmentScore
               {
                   Id = 1,
                   Name = "Developer",
                   Min = 0,
                   Max = 13,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee
               },
               new AssessmentScore
               {
                   Id = 2,
                   Name = "Performer",
                   Min = 14,
                   Max = 31,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee
               },
               new AssessmentScore
               {
                   Id = 3,
                   Name = "Outstanding",
                   Min = 32,
                   Max = 39,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee
               },
               new AssessmentScore
               {
                   Id = 4,
                   Name = "Developer",
                   Min = 0,
                   Max = 15,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Manager
               },
               new AssessmentScore
               {
                   Id = 5,
                   Name = "Performer",
                   Min = 16,
                   Max = 36,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Manager
               },
               new AssessmentScore
               {
                   Id = 6,
                   Name = "Outstanding",
                   Min = 37,
                   Max = 45,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Manager
               },
               new AssessmentScore
               {
                   Id = 7,
                   Name = "N/A",
                   Min = -1,
                   Max = -1,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Employee
               },
               new AssessmentScore
               {
                   Id = 8,
                   Name = "N/A",
                   Min = -1,
                   Max = -1,
                   ScoreCriteriaId = (int)enumm.ScoreCriteria.Manager
               });

            modelBuilder.Entity<Language>()
           .HasData(new Language
           {
               Id = 1,
               Code = "en",
               Description = "English"
           }, new Language
           {
               Id = 2,
               Code = "sv",
               Description = "Swedish"
           });

            modelBuilder.Entity<TranslationQuestionnaire>()
                .HasData(new TranslationQuestionnaire
                {
                    Id = 1,
                    LanguageId = 1,
                    QuestionsJson = "[{}]"

                },
                new TranslationQuestionnaire
                {
                    Id = 2,
                    LanguageId = 2,
                    QuestionsJson = "[{}]"

                },
                new TranslationQuestionnaire
                {
                    Id = 3,
                    LanguageId = 1,
                    QuestionsJson = "[{}]"

                },
                new TranslationQuestionnaire
                {
                    Id = 4,
                    LanguageId = 2,
                    QuestionsJson = "[{}]"

                }
            );

            modelBuilder.Entity<TranslationQuestionnaire>()
                .HasIndex(x => new { x.LanguageId });

            modelBuilder.Entity<AssessmentQuestionnaire>()
                .HasData(
                    new AssessmentQuestionnaire()
                    {
                        Id = 1,
                        AssessmentTemplateId = 1,
                        TranslationQuestionnaireId = 1
                    },
                    new AssessmentQuestionnaire()
                    {
                        Id = 2,
                        AssessmentTemplateId = 1,
                        TranslationQuestionnaireId = 2
                    },
                    new AssessmentQuestionnaire()
                    {
                        Id = 3,
                        AssessmentTemplateId = 2,
                        TranslationQuestionnaireId = 1
                    },
                    new AssessmentQuestionnaire()
                    {
                        Id = 4,
                        AssessmentTemplateId = 2,
                        TranslationQuestionnaireId = 2
                    }
                );

            modelBuilder.Entity<TemplatePermission>()
                .HasIndex(x => x.PermissionId);

            modelBuilder.Entity<ScoreCriteria>()
               .HasData(new ScoreCriteria()
               {
                   Id = 1,
                   Description = "Manager"
               }, new ScoreCriteria()
               {
                   Id = 2,
                   Description = "Employee"
               });

            modelBuilder.Entity<AssessmentTemplate>()
           .HasOne(t => t.Assessment)
           .WithMany(a => a.AssessmentTemplates)
           .HasForeignKey(t => t.AssessmentCode)
           .HasPrincipalKey(a => a.AssessmentCode);

            modelBuilder.Entity<TemplatePermission>()
            .HasOne(t => t.AssessmentTemplate)
            .WithMany(a => a.TemplatePermissions)
            .HasForeignKey(t => t.AssessmentTemplateId)
            .HasPrincipalKey(a => a.Id);

            modelBuilder.Entity<Assessment>()
              .HasData(new Assessment()
              {
                  Id = 1,
                  AssessmentCode = "PA2020",
                  Name = "Performance Appraisal 2020"
              }, new Assessment()
              {
                  Id = 2,
                  AssessmentCode = "SD2020",
                  Name = "Salary Discussion 2020"
              });

            modelBuilder.Entity<AssessmentUserStatus>()
            .Property(b => b.formChanged)
            .HasDefaultValue(false);

            modelBuilder.Entity<AssessmentUserComment>()
            .Property(x => x.ParentId)
            .HasDefaultValue(0);

            modelBuilder.Entity<AssessmentLinkForm>()
           .Property(x => x.CreatedDate)
           .HasDefaultValue(DateTime.UtcNow);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AssessmentBaseClass && (e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((AssessmentBaseClass)entityEntry.Entity).DateModified = DateTime.UtcNow;
            }

            return (await base.SaveChangesAsync(true, cancellationToken));
        }
    }
}
