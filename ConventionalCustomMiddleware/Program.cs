
using ConventionalCustomMiddleware.ConventionalCustomMiddleware;
namespace ConventionalCustomMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           // builder.Services.AddTransient<MyConventionalCustomMiddleware>();
            var app = builder.Build();

            app.Use(async (HttpContext context, RequestDelegate next) => {

                await context.Response.WriteAsync("first BuiltIn middleware starts");
                next(context);
                await context.Response.WriteAsync("first BuiltIn middleware ends");


            });

            app.UseConventionalMiddleware();
            app.UseHelloConventionalMiddleware();


            app.UseWhen(

                context => context.Request.Path.StartsWithSegments("/api")

                ,
                branch => branch.UseMiddleware<HelloConventionalMiddleware>()
                );

            app.Run();
        }
    }
}
