using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro029_IActionResultExample_OnlineLibraryValidation.Controllers
{
    public class HomeController : Controller
    {
        [Route("/bookstore")]
        public IActionResult GetBook()
        {
            if (!HttpContext.Request.Query.ContainsKey("isloggedin")) {

                // not logged in 
                //    HttpContext.Response.StatusCode=400;
                //    return new ContentResult() { Content = "an unauthenticated access", ContentType = "text/plain" };

                 

                return BadRequest("an unauthenticated access");
                
            }
            string? isLoggedIn = Convert.ToString(HttpContext.Request.Query["isloggedin"]);

            if (string.IsNullOrEmpty(isLoggedIn))
            {

                //// not logged in 
                //HttpContext.Response.StatusCode = 400;

                //return new ContentResult() { Content = "an unauthenticated access", ContentType = "text/plain" };
                return BadRequest("an unauthenticated access");
            }

            if ((isLoggedIn!="true"))
            {

                // not logged in 
                //HttpContext.Response.StatusCode = 400;

                //return new ContentResult() { Content = "an unauthenticated access", ContentType = "text/plain" };
                return BadRequest("an unauthenticated access");

            }

            // no id is supplied 
            if (!HttpContext.Request.Query.ContainsKey("bookid")) {
                //HttpContext.Response.StatusCode = 400;

               // return new ContentResult() { Content = "You Missed the Book ID you want ", ContentType = "text/plain" };
                return NotFound("You Missed the Book ID you want");

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

            // return new RedirectToActionResult("RetreiveBook", "Store", new {}, true);
            //return RedirectPermanent("book/store");
            //return  RedirectPermanent("https://www.youtube.com");
            return LocalRedirectPermanent("book/store");


        }
    }
}
