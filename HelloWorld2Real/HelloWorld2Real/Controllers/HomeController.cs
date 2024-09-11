using Microsoft.AspNetCore.Mvc;

namespace HelloWorld2Real.Controllers
{
    public class HomeController : Controller  // controller
    {
        public string Index()    // action
        {
            return "Uygulama calisiyor";

        }
        public string Test()
        {
            return "bu test action vardir";
        }
        public IActionResult Selamla() 
        { 
            ViewResult result = View();
            return result;
        }
    }
}
