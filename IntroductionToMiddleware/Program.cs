namespace IntroductionToMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();

            app.Run(async (HttpContext context) => {

                await context.Response.WriteAsync("helooooooooooooo sasa ");
            
            
            
            });
            // denpending on app.run method that terminating seqeuntial pipeline of middlewares
            // output will be helooooooooooooo sasa only ;

            app.Run(async (HttpContext context) => {

                await context.Response.WriteAsync("helooooooooooooo sasa again");



            });

             app.Run();
        }
    }
}
