using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace ProjectHRCommon.Middleware
{
    [ExcludeFromCodeCoverage]
    public class HealthCheckMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _path;
        private readonly string _connectionString;

        public HealthCheckMiddleware(RequestDelegate next, string path, string connectionString)
        {
            _next = next;
            _path = path;
            _connectionString = connectionString;
        }


        private static Task ResponseMessage(HttpContext context, string message, int statusCode)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(message);
        }

        public async Task InvokeAsync(HttpContext context)
        {

            if (context.Request.Path.Value == _path)
            {
                try
                {
                    using (var db = new MySqlConnection(_connectionString))
                    {
                        await db.OpenAsync();
                        db.Close();
                    }
                    await ResponseMessage(context, "Healthy!", 200);
                }
                catch (MySqlException)
                {
                    await ResponseMessage(context, "Database connection failed!", 400);
                }
            }
            else
                await this._next(context);

        }
    }
}
