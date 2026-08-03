 using Microsoft.AspNetCore.Mvc;

namespace aspnet_pro023_ControllersFirstProject.Controllers
{
    [Route("home")]
    [Controller]
   public class HomeController 
    {
        [Route("m1")]

        public string Method1()
        {
            return "Hello from Method1 ";
        }

        [Route("m2")]

        public string Method2()
        {
            return "Hello from Method2";
        }
    }
}
