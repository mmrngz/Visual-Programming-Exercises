using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id,string productName)
        {
            return View();
        }
    }
}
