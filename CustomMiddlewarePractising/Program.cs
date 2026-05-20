using CustomMiddlewarePractising.CustomMiddleware;

namespace CustomMiddlewarePractising
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<MyCustomMiddleware>();
            var app = builder.Build();

            app.Use(async(HttpContext context , RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n this is the starter middleware 1 in request middleware pipeline");

                next(context);

                await context.Response.WriteAsync("\n return control back to middleware 1 after finishing middleware 2");

            });

            app.UseMyMiddleware();


            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n this is middleware 2 in request middleware pipeline");

                await next(context);

                await context.Response.WriteAsync("\n return control back to middleware 2 after finishing middleware 3");

            });
              


            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("\n this is final middleware 3 in request middleware pipeline");
            });


            app.Run();
        }
    }
}
