using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace aspnet_pro024_ControllerWithMultipleActions.Controllers
{
    [Controller]
    [Route("home")]
    public class MyHomeController
    {

        [Route("action1")]
        public string Action1()
        {
            return "welcome to action 1";

        }

        [Route("action2")]

        public string Action2()
        {
            return "welcome to action 2";

        }

        [Route("action3")]
        public string Action3()
        {
            return "welcome to action 3";

        }

        [Route("contact/{phone:regex(^\\d{{10}}$)}")]
        public string Contact(string phone)
    {
        return $"You can contact us on phone : {phone}";

    }


}
}
