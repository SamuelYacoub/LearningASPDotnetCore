namespace IntroToRoutingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Routing is automatially enabled 
            // no need for app.useRouting() anymore 
            // endpoints are defined directly on the "app" object
            // We will add endpoint here 

            app.Map("/", async (HttpContext context) => { 
                await context.Response.WriteAsync("samuel"); 
                 
            
            
            });

            app.Map("/map1", async (HttpContext context) => 
            {
                await context.Response.WriteAsync("we received the request in url map1111111");

                string pathOfFile = "D:\\Samuel_Yacoub\\معيد كلية الحاسبات جامعة الريادة يونيو 2026\\Asp.Net Core 10 (.NET 10)   True Ultimate Guide_Course_Content.txt";
                StreamReader reader = new StreamReader(pathOfFile);
                 string fileContent=reader.ReadToEnd();
                await context.Response.WriteAsync(fileContent);


            });

            app.Map("/map2", async (HttpContext context) => 
            {
                await context.Response.WriteAsync("we received the request in url map2222222");




            });

            app.MapFallback(async (context) =>
            {
                await context.Response.WriteAsync($"Request received at {context.Request.Path}");

            }); 


            app.Run(); 
        }
    }
}
