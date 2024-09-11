using Microsoft.AspNetCore.Mvc;

namespace ViewStructure.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Link1()
		{
			return View();
		}
		public IActionResult Link2()
		{
			return View();
		}
		public IActionResult LoginAsTeacher()
		{
			return View();

		}
		public IActionResult LoginAsStudent()
		{
			return View();
		}
	}
}
