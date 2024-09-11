using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcProject.UI.Controllers
{
	[Authorize(Policy = "UserPolicy")]
	public class AboutController : Controller
	{
		public IActionResult AboutView()
		{
			return View();
		}
	}
}
