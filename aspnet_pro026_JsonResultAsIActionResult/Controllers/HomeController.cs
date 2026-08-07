using Microsoft.AspNetCore.Mvc;
using aspnet_pro026_JsonResultAsIActionResult.Models;

namespace aspnet_pro026_JsonResultAsIActionResult.Controllers
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


        [Route("person")]

        public JsonResult Person()
        {
            Person? person = (new Person() { FirstName = "Samuel", Id = Guid.NewGuid(), LastName = "Yacoub", Age = 25 });
          //  return new JsonResult(person);
            return Json(person);
        }


        [Route("contact")]

        public string Contact()
        {
            return "hello from Contact";
        }
    }
}
