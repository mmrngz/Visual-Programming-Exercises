using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
