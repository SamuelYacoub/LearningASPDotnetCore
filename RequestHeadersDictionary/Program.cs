namespace RequestHeadersDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.Run(async (HttpContext context) => {


            //    string path = context.Request.Path;
            //    string method = context.Request.Method;
            //    context.Request.Headers["Content-Type"] = "text/html";

            //    await context.Response.WriteAsync($"the path : {path} \n");
            //    await context.Response.WriteAsync($"the method : {method}");




            //});

            //app.Run(async (HttpContext context) => {


            //    context.Request.Headers["Content-Type"] = "text/html";

            //    if (context.Request.Method == "GET")
            //    {
            //        if (context.Request.Query.ContainsKey("id"))
            //        {
            //            string id = context.Request.Query["id"];
            //            await context.Response.WriteAsync($"<h1>{id}<h1>");
            //        }
            //    }



            //});


            app.Run(async (HttpContext context) => {


                context.Request.Headers["Content-Type"] = "text/plain";

                if (context.Request.Headers.ContainsKey("User-Agent"))
                {
                        string userAgent = context.Request.Headers["User-Agent"];
                        await context.Response.WriteAsync($"<h1>{userAgent}<h1>");
                    
                        
                }

                context.Request.Headers["languagee"] = "arabic";
                context.Response.WriteAsync(context.Request.Headers["languagee"].ToString());


                if (context.Request.Headers.ContainsKey("Date"))
                {
                    string date = context.Request.Headers["Date"].ToString() ;
                    await context.Response.WriteAsync($"<h1>{date}<h1>");

                    context.Request.Headers["Date"] = "monday 15 sep 2025 ";
                }

            });
            app.Run();
        }
    }
}
