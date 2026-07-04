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


            app.MapGet("library/{category}/{filename}.{extension=kharah}", async (context) =>
            {
                string? category = Convert.ToString(context.Request.RouteValues["category"]);
                string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
                string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

                await context.Response.WriteAsync($"we recive the request of file from our library from - {category} " +
                    $"with name {fileName} and extension of file is {extension}");




            });


            app.MapPost("/education/{school}/{classs}/{student}/{id=100}", async (HttpContext context) =>
            {
                string? school = Convert.ToString(context.Request.RouteValues["school"]);
                string? classs = Convert.ToString(context.Request.RouteValues["classs"]);
                string? student = Convert.ToString(context.Request.RouteValues["student"]);
                int? id = Convert.ToInt32(context.Request.RouteValues["id"]);

                await context.Response.WriteAsync($"the info of student that you post is \n his name is {student} \n his school is {school}" +
                    $"\n his class is {classs} \n his id is {id}");




            });

            app.MapGet("/products/detials/{id?}", async (HttpContext context) =>
            {
                int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                await context.Response.WriteAsync($"ok sir we will get the details of product id = {id}");

            });
            app.Map("/school/{grade}/{student?}", async (context) =>
            {
                string? grade = Convert.ToString(context.Request.RouteValues["grade"]);
                string? student = Convert.ToString(context.Request.RouteValues["student"]);

                await context.Response.WriteAsync($"the in the school and the student whose name is {student} his grade is {grade} ");

            });

            app.Map("/hospital/{patient}/{id?}", async (context) =>
            {
                if (context.Request.RouteValues.ContainsKey("id"))
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    string? patient = Convert.ToString(context.Request.RouteValues["patient"]);
                    await context.Response.WriteAsync($"in our hospital the patient {patient} with id {id} his health is verygood ");


                }
                else
                    await context.Response.WriteAsync("you have missed the id of the patient ");
            });

            app.MapFallback(async (context) =>
            {
                await context.Response.WriteAsync($"sorry, there isn't an endpoint that matches your requested url at \n {context.Request.Path}");
            });
            app.Run();
        }
    } 
}
