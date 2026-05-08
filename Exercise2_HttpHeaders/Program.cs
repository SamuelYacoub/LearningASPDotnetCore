using System.Xml.Linq;

namespace Exercise2_HttpHeaders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async(HttpContext context) =>
            {

                context.Response.ContentType = "text/html";
                if (context.Request.Method == "GET")
                {
                    if (context.Request.Query.ContainsKey("name"))
                    {
                        string name = context.Request.Query["name"];
                        await context.Response.WriteAsync($"<h1>Welcome {name} <h1>");
                    }

                    else
                        await context.Response.WriteAsync("<h1>Name not found<h1> ");
                }
            });

            app.Run();
        }
    }
}
