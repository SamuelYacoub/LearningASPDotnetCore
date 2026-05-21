
using CustomMiddlewarePractising.CheckCondtionMiddleware;
using Microsoft.AspNetCore.Builder;
namespace CustomMiddlewarePractising.CheckCondtionMiddleware


{
    public static class ExtensionMethodCheckCondition
    {

        public static IApplicationBuilder UseCheckCondition(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CheckConditionMiddleware>();

        }

    }
}
