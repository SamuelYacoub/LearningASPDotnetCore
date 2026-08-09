using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro028_IActionResultAsActionRestult.Controllers
{
    [Controller]
    public class HomeController
    {

        // [Route("")]
        public IActionResult Index()
        {

            return new ContentResult() { Content = "sasa", ContentType = "text/plain" };


        }

        [Route("")]
        [Route("filedownload1")]
        public IActionResult FileDownload1()
        {

            return new VirtualFileResult("english.pdf", "application/pdf");


        }

        [Route("filedownload2")]

        public IActionResult FileDownload2()
        {

            return new PhysicalFileResult(@"D:\projects\asp.net_core_projects\aspnet_pro027_FileResultAsActionResult\wwwroot\english.pdf", "application/pdf");


        }
        [Route("filedownload3")]

        public IActionResult FileDownload3()
        {

            byte[] bytes = System.IO.File.ReadAllBytes(@"D:\projects\asp.net_core_projects\aspnet_pro027_FileResultAsActionResult\wwwroot\english.pdf");
            return new FileContentResult(bytes, "application/pdf");

        }
    }
 }
