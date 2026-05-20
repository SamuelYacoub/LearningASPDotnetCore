
namespace CustomMiddlewarePractising.CustomMiddleware
{
    public static class ExtensionMethodForCustomMiddleware
    {

        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app) {
            return app.UseMiddleware<MyCustomMiddleware>();
        
        

        
        
        }
        


        

    }
}
