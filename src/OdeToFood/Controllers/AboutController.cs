using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+46 709 111 333";
        }
        public string Address()
        {
            return "Sweden";
        }
    }
}
