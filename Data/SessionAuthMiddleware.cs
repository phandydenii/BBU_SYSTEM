using System;
namespace BBU_SYSTEM.Data
{
    public class SessionAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;

            // Allow anonymous paths
            if (path.StartsWithSegments("/Account") || path.StartsWithSegments("/css") || path.StartsWithSegments("/js"))
            {
                await _next(context);
                return;
            }

            // Check session
            var username = context.Session.GetString("username");
            if (string.IsNullOrEmpty(username))
            {
                context.Response.Redirect("/Account/Login");
                return;
            }

            await _next(context);
        }
    }

}

