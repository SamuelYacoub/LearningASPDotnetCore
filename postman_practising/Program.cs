namespace postman_practising
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) => {


                context.Response.ContentType = "text/html";
                context.Request.Headers["AuthorizationKey"] = "100001";

                if (context.Request.Headers.ContainsKey("AuthorizationKey")) { 
                    string auth = context.Request.Headers["AuthorizationKey"];
                    await context.Response.WriteAsync($" <p>the authoriazation key : {auth} <p>");
               
                }
            
            
            
            
            
            
            
            
            
            });

            app.Run();
        }
    }
}
