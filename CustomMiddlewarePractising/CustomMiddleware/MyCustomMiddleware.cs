namespace CustomMiddlewarePractising.CustomMiddleware
{ 
    public class MyCustomMiddleware : IMiddleware
    {
       

        public async  Task InvokeAsync(HttpContext context, RequestDelegate next) {

            await context.Response.WriteAsync("My Custome Middleware starts");
            await next(context);
            await context.Response.WriteAsync("My Custome Middleware ends");
        }


       
    }
}
