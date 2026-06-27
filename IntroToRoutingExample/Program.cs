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

            app.Run();
        }
    }
}
