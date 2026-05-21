namespace CustomMiddlewarePractising.CheckCondtionMiddleware
{
    public class CheckConditionMiddleware : IMiddleware
    {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            if (1 == 1)
            {

                await context.Response.WriteAsync("\n My CheckCondition Middleware starts");

            }

            await next(context);

            if (1 == 1)
            {

                await context.Response.WriteAsync("\n My CheckCondition Middleware ends");

            }


        }




    }
}
