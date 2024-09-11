﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcProject.UI.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
