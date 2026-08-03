namespace aspnet_pro023_ControllersFirstProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.MapControllers();
       

            app.Run();
        }
    }
}
