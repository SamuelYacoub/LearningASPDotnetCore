namespace RoutingUsingMapGet_MapPost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/map1", async (context) =>
            {
                await context.Response.WriteAsync($"we recive the request get at {context.Request.Path}");
            });

            app.MapPost("/map2", async (context) =>
            {
                await context.Response.WriteAsync($"we recive the request post at {context.Request.Path}");
            });

            app.MapFallback(async (context) =>
            {
                await context.Response.WriteAsync($"failed to matches the  {context.Request.Path}");
            });
            app.Run();
        }
    }
}
