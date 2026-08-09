using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro027_FileResultAsActionResult.Controllers
{
    [Controller]
    public class HomeController
    {

       // [Route("")]
        public ContentResult Index()
        {

            return new ContentResult() { Content="sasa",ContentType= "text/plain" };


        }

        [Route("")]
        [Route("filedownload1")]
        public VirtualFileResult FileDownload1() {

            return new VirtualFileResult("english.pdf","application/pdf");
        
        
        }

        [Route("filedownload2")]

        public PhysicalFileResult FileDownload2()
        {

            return new PhysicalFileResult(@"D:\projects\asp.net_core_projects\aspnet_pro027_FileResultAsActionResult\wwwroot\english.pdf", "application/pdf");


        }
        [Route("filedownload3")]

        public FileContentResult FileDownload3()
        {

            byte[] bytes=System.IO.File.ReadAllBytes(@"D:\projects\asp.net_core_projects\aspnet_pro027_FileResultAsActionResult\wwwroot\english.pdf");
            return new FileContentResult(bytes,"application/pdf");

        }
    }
}

