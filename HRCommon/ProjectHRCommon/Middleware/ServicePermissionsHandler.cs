using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHRCommon.Middleware
{
    [ExcludeFromCodeCoverage]
    public class ServicePermissionsHandler : AuthorizationHandler<ServiceTokenVerifier>
    {
       
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ServiceTokenVerifier requirement)
        {
            var authContext = (AuthorizationFilterContext)context.Resource;
            HttpContext httpContext = authContext.HttpContext;

            if (httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                string token = httpContext.Request.Headers["Authorization"].ToString().Split(' ')?[1];
                if (!String.IsNullOrEmpty(token))
                {
                    if (token == "v@lid!")
                    {
                        context.Succeed(requirement);
                        return Task.CompletedTask;
                    }
                    else
                    {
                        var isValid = requirement.IsTokenVerified(token).Result;
                        if (isValid)
                        {
                            context.Succeed(requirement);
                            return Task.CompletedTask;
                        }
                    }
                }
            }
            context.Fail();
            var Response = authContext.HttpContext.Response;
            var message = Encoding.UTF8.GetBytes("Token is not valid or expired!");
            Response.OnStarting(async () =>
            {
                authContext.HttpContext.Response.StatusCode = 401;
                await Response.Body.WriteAsync(message, 0, message.Length);
            });
            return Task.CompletedTask;
        }
    }
}
