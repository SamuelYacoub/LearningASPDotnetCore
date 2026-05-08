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

                if (context.Request.Method == "GET")
                {
                    if (context.Request.Headers.ContainsKey("AuthorizationKey")) ;
                    string auth = context.Request.Headers["AuthorizationKey"];
                    await context.Response.WriteAsync($"the authoriazation key : {auth}");
                }
            
            
            
            
            
            
            
            
            
            
            });

            app.Run();
        }
    }
}
