using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro029_IActionResultExample_OnlineLibraryValidation.Controllers
{
    public class HomeController : Controller
    {
        [Route("/book")]
        public IActionResult GetBook()
        {
            if (!HttpContext.Request.Query.ContainsKey("isloggedin")) {

                // not logged in 
                HttpContext.Response.StatusCode=400;
                return new ContentResult() { Content = "an unauthorized access", ContentType = "text/plain" };
            }
            string? isLoggedIn = Convert.ToString(HttpContext.Request.Query["isloggedin"]);

            if (string.IsNullOrEmpty(isLoggedIn))
            {

                // not logged in 
                HttpContext.Response.StatusCode = 400;

                return new ContentResult() { Content = "an unauthorized access", ContentType = "text/plain" };
            }

            if ((isLoggedIn!="true"))
            {

                // not logged in 
                HttpContext.Response.StatusCode = 400;

                return new ContentResult() { Content = "an unauthorized access", ContentType = "text/plain" };
            }

            // no id is supplied 
            if (!HttpContext.Request.Query.ContainsKey("bookid")) {
                HttpContext.Response.StatusCode = 400;

                return new ContentResult() { Content = "You Missed the Book ID you want ", ContentType = "text/plain" };


            }

            int bookId = Convert.ToInt32(HttpContext.Request.Query["bookid"]);
            // no id is supplied 

            if (string.IsNullOrEmpty(Convert.ToString(HttpContext.Request.Query["bookid"]))) {
                HttpContext.Response.StatusCode = 400;

                return new ContentResult() { Content = "You Missed the Book ID you want ", ContentType = "text/plain" };


            }
            // id is negative
            // id exceeds the minimum range of 1 


            if (bookId < 0) { 
                HttpContext.Response.StatusCode=400;

                return new ContentResult() { Content = "You entered Book ID Wrong should be positive", ContentType = "text/plain" };



            }
            // id exceeds the maximum range of 1000

            if (bookId > 1000) { 
                HttpContext.Response.StatusCode=400;

                return new ContentResult() { Content = "You entered Book ID Wrong shouldn't  be greater than 1000 ", ContentType = "text/plain" };


            }

            // the ok status 
            HttpContext.Response.StatusCode = 200;

            return File("/ielts.pdf" ,"application/pdf" );
            


        }
    }
}
