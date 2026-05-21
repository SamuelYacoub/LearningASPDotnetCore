using CustomMiddlewarePractising.CustomMiddleware;
using CustomMiddlewarePractising.CheckCondtionMiddleware;
namespace CustomMiddlewarePractising
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<MyCustomMiddleware>();
            builder.Services.AddTransient<CheckConditionMiddleware>();
            var app = builder.Build();

            app.Use(async(HttpContext context , RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n first builtin middleware starts");

                next(context);

                await context.Response.WriteAsync("\n first builtin middleware ends");

            });
            app.UseCheckCondition();

            app.UseMyMiddleware();


            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n second builtin middleware starts ");

                await next(context);

                await context.Response.WriteAsync("\n second builtin  middleware ends");

            });
              


            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n third and final builtin middleware (terminal) no next gooooooo back ");
            });


            app.Run();
        }
    }
}
