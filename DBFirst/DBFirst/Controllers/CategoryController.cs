using DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DBFirst.Controllers
{
	public class CategoryController : Controller
	{
		CinemaDBContext dbContext;
		public CategoryController(CinemaDBContext _dBContext) 
		{
			dbContext = _dBContext;	
		}	
		public IActionResult List()
		{
			List<Category> list = dbContext.Categories.ToList();
			return View(list);
		}
	}
}
