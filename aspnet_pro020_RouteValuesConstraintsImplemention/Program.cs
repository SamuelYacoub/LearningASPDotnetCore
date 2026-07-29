using aspnet_pro020_RouteValuesConstraintsImplemention.RoutingConstraints;

namespace aspnet_pro020_RouteValuesConstraintsImplemention
{
    public class Program
    {
        public static void Main(string[] args)
        {
          

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRouting(options =>
            {
                options.ConstraintMap.Add(
                    "MonthsCustomConstraint",
                    typeof(MonthsCustomConstraint)
                );
            });

            var app = builder.Build();

            app.Map("employee/profile/{EmployeeName}",async (context) =>
            {
                string? EmployeeName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);
                await context.Response.WriteAsync($"In Employee profile - {EmployeeName}");
            });

            app.Map("product/detials/{id:int?}", async (context) =>
            {
                int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                await context.Response.WriteAsync($"the product with id  - {id} - its details are : ");
            });

            app.Map("daily-digest-report/{reportdate:datetime}", async (context) => {
                DateTime reportdate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
                await context.Response.WriteAsync($"the report date is {reportdate.ToShortDateString()}");
                
            
            
            });

            app.Map("cities/{cityid:guid}", async (context) =>
            {
                Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"]));
                await context.Response.WriteAsync($"the City Id is  {cityId.ToString()}");
            });

            app.Map("calendar/{year:int}/{month:MonthsCustomConstraint}", async (context) =>
            {
                string? month = Convert.ToString(context.Request.RouteValues["month"]);
                int year = Convert.ToInt32(context.Request.RouteValues["year"]);

                await context.Response.WriteAsync($"your month is {month} at year {year}");
            });




            app.MapFallback( async (context) =>   
            {
               
                await context.Response.WriteAsync($"no endpoints match at this url : [ {context.Request.Path.ToString()} ]");
            });

            app.Run();
        }
    }
}
