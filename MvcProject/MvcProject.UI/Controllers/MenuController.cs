﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcProject.UI.Controllers
{
	[Authorize(Policy = "UserPolicy")]
	public class MenuController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
