using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using persistence = AssessmentPersistence;
using manager = AssessmentManager;
using Microsoft.AspNetCore.Authorization;
using ProjectHRCommon.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectHRCommon.Client;
using System.Diagnostics.CodeAnalysis;
using ProjectHRCommon.Abstract;

namespace API_Assessment_Service_2_1.Configuration
{
    [ExcludeFromCodeCoverage]
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext_LocalDockerMySql(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:ProjectHRDB_LocalDocker"];

            services.AddDbContext<persistence.DataContext>(options =>
                options.UseMySql(connectionString,
                mysqlOptions =>
                {
                    mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                })
                );

        }

        public static void ConfigureMySqlContext_LocalSql(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:ProjectHRDB_LocalSql"];
            services.AddDbContext<persistence.DataContext>(options =>
                         options.UseMySql(connectionString,
                         mysqlOptions =>
                         {
                             mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                         })
                         );


        }

        public static void ConfigureMySqlContext_Dev_Proxy(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Dev_Proxy"];
            services.AddDbContext<persistence.DataContext>(options =>
                         options.UseMySql(connectionString,
                         mysqlOptions =>
                         {
                             mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                         })
                         );


        }

        public static void ConfigureMySqlContext_Stage_Proxy(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Stage_Proxy"];
            services.AddDbContext<persistence.DataContext>(options =>
                         options.UseMySql(connectionString,
                         mysqlOptions =>
                         {
                             mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                         })
                         );


        }

        public static void ConfigureMySqlContext_Prod_Proxy(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Prod_Proxy"];
            services.AddDbContext<persistence.DataContext>(options =>
                         options.UseMySql(connectionString,
                         mysqlOptions =>
                         {
                             mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                         })
                         );


        }

        public static void ConfigureMySqlContext_CloudSql_Dev(this IServiceCollection services, IConfiguration config)
        {

            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Dev"];
            services.AddDbContext<persistence.DataContext>(options =>
                          options.UseMySql(connectionString,
                          mysqlOptions =>
                          {
                              mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                          })
                          );
        }

        public static void ConfigureMySqlContext_CloudSql_Stage(this IServiceCollection services, IConfiguration config)
        {

            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Stage"];

            services.AddDbContext<persistence.DataContext>(options =>
                options.UseMySql(connectionString,
                mysqlOptions =>
                {
                    mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                })
                );
        }

        public static void ConfigureMySqlContext_CloudSql_Prod(this IServiceCollection services, IConfiguration config)
        {

            var connectionString = config["ConnectionString:ProjectHRDB_CloudSql_Prod"];
            services.AddDbContext<persistence.DataContext>(options =>
                          options.UseMySql(connectionString,
                          mysqlOptions =>
                          {
                              mysqlOptions.ServerVersion(new Version(5, 7, 29), ServerType.MySql);
                          })
                          );
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<persistence.IAssessmentUserStatusPersistence, persistence.AssessmentUserStatusPersistence>();
            services.AddScoped<persistence.ICrudAssessmentPersistence, persistence.AssessmentUserStatusPersistence>();
            services.AddScoped<manager.IAssessmentUserStatusManager, manager.AssessmentUserStatusManager>();

            services.AddScoped<persistence.IAssessmentScorePersistence, persistence.AssessmentScorePersistence>();
            services.AddScoped<manager.IAssessmentScoreManager, manager.AssessmentScoreManager>();

            services.AddScoped<persistence.IAssessmentAnswersPersistence, persistence.AssessmentAnswersPersistence>();

            services.AddScoped<persistence.IAssessmentQuestionsPersistence, persistence.AssessmentQuestionsPersistence>();
            services.AddScoped<manager.IAssessmentQuestionnaireManager, manager.AssessmentQuestionnaireManager>();

            services.AddScoped<persistence.IAssessmentTemplatePersistence, persistence.AssessmentTemplatePersistence>();
            services.AddScoped<manager.IAssessmentTemplateManager, manager.AssessmentTemplateManager>();

            services.AddScoped<persistence.IAssessmentLanguagePersistence, persistence.AssessmentLanguagePersistence>();
            services.AddScoped<manager.IAssessmentLanguageManager, manager.AssessmentLanguageManager>();

            services.AddScoped<manager.IAssessmentAnswerManager, manager.AssessmentAnswerManager>();
            services.AddScoped<persistence.IAnswerPersistence, persistence.AnswerPersistence>();

            services.AddScoped<persistence.IQuestionnaireDomPersistence, persistence.QuestionnaireDomPersistence>();

            services.AddSingleton<IAuthorizationHandler, ServicePermissionsHandler>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void ConfigureAuthorizationPolicy(this IServiceCollection services, IConfiguration config)
        {
            ClientCall clientCall = new ClientCall();
            var api = $"{config["domain"]}{config["version"]}{config["enpoint"]}";

            services.AddAuthorization(options =>
            {
                options.AddPolicy("VerifiedTokenOnly", policy => policy.Requirements.Add(new ServiceTokenVerifier(clientCall, api)));
            });
        }

        public static void ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });
        }

        //Cross-Origin Resource Sharing
        public static void ConfigureCors(this IServiceCollection services, string _myCors)
        {
            services.AddCors(x => x.AddPolicy(_myCors, builder =>
            {
                builder.WithOrigins("https://*.transcom.com",
                                    "https://*.appspot.com",
                                    "https://localhost:4200",
                                    "https://app-projecthr-dot-tww-ccs-northhr-prod.appspot.com",
                                    "https://app-projecthr-stage-dot-tww-ccs-northhr-prod.appspot.com",
                                    "https://app-projecthr-prod-dot-tww-ccs-northhr-prod.appspot.com")
                       .SetIsOriginAllowedToAllowWildcardSubdomains()
                       .AllowAnyHeader()
                       .AllowAnyMethod();

            }));
        }


    }
}
