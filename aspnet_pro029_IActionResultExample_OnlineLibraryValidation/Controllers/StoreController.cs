using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro029_IActionResultExample_OnlineLibraryValidation.Controllers
{
    public class StoreController : Controller
    {
        [Route("book/store")]
        public IActionResult RetreiveBook()
        {
            return File("/ielts.pdf","application/pdf");
        }
    }
}
