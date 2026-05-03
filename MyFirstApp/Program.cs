namespace MyFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            Console.WriteLine(); 
            app.MapGet("/", () => "hi my name is samuel ;;;");

            app.Run();
        }
    }
}
