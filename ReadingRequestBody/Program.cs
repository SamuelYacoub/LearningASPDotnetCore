using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace ReadingRequestBody
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.Run(async (HttpContext context) =>
            //{
            //    string body="";
            //    if (context.Request.Method == "POST")
            //    {
            //         body = await new StreamReader(context.Request.Body).ReadToEndAsync();
            //    }

            //  await  context.Response.WriteAsync(body.ToString());
            //});


            //app.Run(async (HttpContext context) =>
            //{
            //    StreamReader reader = new StreamReader(context.Request.Body);


            //        string body = await reader.ReadToEndAsync();


            //    if (body == "samuel") {

            //        for (int i = 0; i < 10; i++) {

            //            await context.Response.WriteAsync($"hi sir {body} \n");

            //        }


            //    }
            //});


            app.Run(async (HttpContext context) =>
            {
                StreamReader reader = new StreamReader(context.Request.Body);


                string body = await reader.ReadToEndAsync();
                Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities
                                                            .QueryHelpers.ParseQuery(body);



                if (queryDict.ContainsKey("firstName")) {


                    string firstName = queryDict["firstName"][0];
                    

                    foreach (var age in queryDict["age"]) {
                        
                        await context.Response.WriteAsync($"The first name of our customer is {firstName} and his age might be {age} ");

                    }
                





                }

            });


            app.Run();
        }
    }
}
