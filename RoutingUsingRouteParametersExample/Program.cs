namespace RoutingUsingRouteParametersExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("products/{category}/{id}", async (HttpContext context) => {

                string? category = Convert.ToString(context.Request.RouteValues["category"]);
                int id = Convert.ToInt32(context.Request.RouteValues["id"]);


                string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
                await context.Response.WriteAsync($"we recive the request at products - {category} with id {id}");
            
            });


            app.MapGet("library/{category}/{filename}.{extension=kharah}",async (context) =>
            {
                string? category     = Convert.ToString(context.Request.RouteValues["category"]);
                string? fileName     = Convert.ToString(context.Request.RouteValues["filename"]);
                string? extension    = Convert.ToString(context.Request.RouteValues["extension"]);

                await context.Response.WriteAsync($"we recive the request of file from our library from - {category} " +
                    $"with name {fileName} and extension of file is {extension}");




            });

            app.Run();
        }
    }
}
