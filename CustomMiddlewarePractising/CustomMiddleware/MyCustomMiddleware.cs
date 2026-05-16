namespace CustomMiddlewarePractising.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAysnc(HttpContext context, RequestDelegate next) {

            await context.Response.WriteAsync("My Custome Middleware starts");
            next(context);
            await context.Response.WriteAsync("My Custome Middleware ends");

        }

    }
}
