namespace AppRunMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) =>
            {
                if (1 ==1)
                {
                    context.Response.StatusCode = 200;
                    context.Response.WriteAsJsonAsync("samuel");
                }
                else { 
                       context.Response.StatusCode = 400;
                       await context.Response.WriteAsync("Hello");
                       await context.Response.WriteAsync(" World");

                }

            });

            app.Run();
        }
    }
}