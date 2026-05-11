using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace Exercise3_MathAppThroughHttpGet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
          

            bool sentFirstNumber = false, sentSecondNumber = false, sentOperation = false;
            app.Run(async (HttpContext context) =>
            {
                int num1 = 0;
                int num2 = 0;
                string operation = "";
                if (context.Request.Path == "/") {
                    Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(context.Request.QueryString.Value);
                   // Dictionary<string, StringValues> queryDict =
                   //QueryHelpers.ParseQuery(context.Request.QueryString.Value ?? "");

                            if (queryDict.ContainsKey("firstNumber")) {

                                string firstNumber = queryDict["firstNumber"][0];
                                num1 = int.Parse(firstNumber);
                                 sentFirstNumber = true;


                             }

                            if (queryDict.ContainsKey("secondNumber"))
                            {

                                string secondNumber = queryDict["secondNumber"][0];
                            num2 = int.Parse(secondNumber);

                        sentSecondNumber = true;


                    }

                    if (queryDict.ContainsKey("operation"))
                             {

                             operation = queryDict["operation"][0];

                        sentOperation = true;


                    }




                }

                if (sentOperation && sentSecondNumber && sentFirstNumber)
                {

                    switch (operation)
                    {

                        case "add":
                            {
                                await context.Response.WriteAsync((num1 + num2).ToString());
                                break;

                            }
                        case "multiply":
                            {
                                await context.Response.WriteAsync((num1 * num2).ToString());
                                break;

                            }
                        case "subtract":
                            {
                                await context.Response.WriteAsync((num1 - num2).ToString());
                                break;

                            }
                        case "division":
                            {
                                if (num2 == 0)
                                {
                                    await context.Response.WriteAsync("division by zero");
                                    break;

                                }
                                await context.Response.WriteAsync((num1 / num2).ToString());
                                break;

                            }
                        default:
                            context.Response.StatusCode = 400;
                            await context.Response.WriteAsync("Invalid input for 'operation'");
                            break;




                    }

                }
        

                else
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Invalid input for 'firstNumber'\r\nInvalid input for 'secondNumber'\r\nInvalid input for 'operation'");




                }
            });
            app.Run();
        }
    }
}
