namespace ResponseHeadersDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) =>
            {




                    context.Response.Headers["name"] = "samuel";
                context.Response.Headers["Content-Type"] = "text/plain";
                context.Response.Headers["role"] = "Backend .net";
                    await context.Response.WriteAsync("<h1>Hello<h1>");
                    await context.Response.WriteAsync(" <h1>World<h1>");

                

            });

            app.Run();
        }
    }
}
