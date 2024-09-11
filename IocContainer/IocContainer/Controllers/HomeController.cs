using IocContainer.Models;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;

namespace IocContainer.Controllers
{
	public class HomeController : Controller
	{
		readonly IConfiguration configuration;
		public HomeController(IConfiguration _configuration) 
		{
			configuration = _configuration;	
		}
		public IActionResult Index()
		{
			string email = configuration["Email"];
			string password = configuration.GetSection("User:Password").Value;
			string name= configuration["User:Name"];	
			User user = configuration.GetSection("User").Get(typeof(User)) as User;
			return View();
		}
	}
}
