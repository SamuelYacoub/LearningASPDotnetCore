using Microsoft.Extensions.FileProviders;

namespace aspnet_pro021_WebRootAndUseStaticFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
            {

                WebRootPath = "samuelroot"

            });


            var app = builder.Build();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "samuelroot"))
            });
          //  app.UseStaticFiles();
            app.MapGet("/", () => "Hello World!");

            

            app.Run();
        }
    }
}
