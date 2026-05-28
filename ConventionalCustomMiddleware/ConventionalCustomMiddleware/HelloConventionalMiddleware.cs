using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConventionalCustomMiddleware.ConventionalCustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public HelloConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public  async Task InvokeAsync(HttpContext httpContext)
        {
            if(httpContext.Request.Query.ContainsKey("firstname") && httpContext.Request.Query.ContainsKey("lastname"))
            {
                string firstname = httpContext.Request.Query["firstname"];
                string lastname = httpContext.Request.Query["lastname"];

                await httpContext.Response.WriteAsync($"\n Hello {firstname} {lastname} \n" +
                     $"");
              
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HelloConventionalMiddlewareExtensions
    {
        public static IApplicationBuilder UseHelloConventionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloConventionalMiddleware>();
        }
    }
}
