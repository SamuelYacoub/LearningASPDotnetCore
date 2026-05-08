namespace Exercise1_HttpHeaders
{
    public class Program
    {
        public static void Main(string[] args)
        {

        //Goal:
        //    Read a request header from browser
        //    then send a custom response header back.
                        var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) => {
                context.Response.Headers["Content-Type"] = "text/html";
                string userAgent = context.Request.Headers["User-Agent"];

                context.Response.Headers["App-Name"] = "MyFirstApp";
                await context.Response.WriteAsync($"user is : {userAgent}");
                await context.Response.WriteAsync("<br> Done");
            
            
            
            
            
            });

            app.Run();
        }
    }
}
