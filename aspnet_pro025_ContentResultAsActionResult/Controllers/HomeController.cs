using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro025_ContentResultAsActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("index")]

        public ContentResult Index()
        {
            //    return "hello from index";
           //  return new ContentResult() { Content="<h1>Hello from index </h1> <h2> i am samuel</h2>",ContentType= "text/html" };
            return Content("<h1>Hello from index </h1>", "text/plain" +
                "");
        }


        [Route("about")]

        public string About()
        {
            return "hello from About";
        }


        [Route("contact")]

        public string Contact()
        {
            return "hello from Contact";
        }
    }
}
