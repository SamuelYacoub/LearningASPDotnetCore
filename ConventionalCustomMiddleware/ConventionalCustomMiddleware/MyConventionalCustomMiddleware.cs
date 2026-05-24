using Microsoft.AspNetCore.Builder;

namespace ConventionalCustomMiddleware.ConventionalCustomMiddleware
{
    public class MyConventionalCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public MyConventionalCustomMiddleware(RequestDelegate next) {
            _next = next;
        
        
        
        }


        public async Task InvokeAsync(HttpContext context) 
        {
            await context.Response.WriteAsync("conventional Custom middleware starts");
            await _next(context);
            await context.Response.WriteAsync("conventional Custom middleware ends");

        }

    }

    public static class ExtentionMethodForConventionalMiddleware {


        public static IApplicationBuilder UseConventionalMiddleware(this IApplicationBuilder app) {

            return app.UseMiddleware<MyConventionalCustomMiddleware>();
        
        }
    
    
    }







}
