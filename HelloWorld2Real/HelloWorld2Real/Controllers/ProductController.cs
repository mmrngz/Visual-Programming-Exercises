using Microsoft.AspNetCore.Mvc;

namespace HelloWorld2Real.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();    
        }
    }
}
