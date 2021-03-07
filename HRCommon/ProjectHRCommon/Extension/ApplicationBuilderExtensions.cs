using Microsoft.AspNetCore.Builder;
using ProjectHRCommon.Middleware;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Extension
{
    [ExcludeFromCodeCoverage]
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseHealthCheck(this IApplicationBuilder builder, string path, string connectionString)
        {
            return builder.UseMiddleware<HealthCheckMiddleware>(path, connectionString);
        }
    }
}
