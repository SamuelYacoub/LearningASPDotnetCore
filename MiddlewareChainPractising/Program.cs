namespace MiddlewareChainPractising
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("i starting the middleware1 ---");

                await next(context);

                await context.Response.WriteAsync("i finishing the middleware1-------");









            });


            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("i starting the middleware2 ----------");

               

                









            });
            app.Run();
        }
    }
}
