using System.Diagnostics.CodeAnalysis;
using API_Assessment_Service_2_1.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectHRCommon.Extension;

namespace API_Assessment_Service_2_1
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        private readonly IHostingEnvironment _env;
        public IConfiguration Configuration { get; }
        private readonly string _myCors = "ProjectHRCors";
        private string _connectionString = string.Empty;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
                    services.ConfigureMySqlContext_LocalSql(Configuration);
                    _connectionString = Configuration["ConnectionString:ProjectHRDB_LocalSql"];
        
            services.ConfigureCors(_myCors);
            services.ConfigureRepositoryWrapper();
            services.ConfigureAuthorizationPolicy(Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.ConfigureApiVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() || _env.IsEnvironment("Debug"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(_myCors);
            app.UseMvc();
            app.UseHealthCheck("/assess-service/health", _connectionString);
        }
    }
}
