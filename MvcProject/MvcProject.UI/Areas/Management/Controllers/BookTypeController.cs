using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.MODEL.Models;
using System.Collections.Generic;

namespace MvcProject.UI.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
	{
        
        //MyDbContext _db;
        IBookTypeRepository repository;
      
        public BookTypeController(IBookTypeRepository repoBookType)
		{
			repository = repoBookType;
			//_db = myDbContext;
		}

		public IActionResult BookTypeList()
		{
			List<BookType> bookTypes = repository.GetAll();
			return View(bookTypes);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(BookType bookType)
		{
			if(!ModelState.IsValid)
			{
				return View(bookType);
			}
			repository.Add(bookType);
			return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });

		}
		public IActionResult Edit(int id)
		{
			BookType bookType = repository.GetById(id);
			return View(bookType);	
		}
		[HttpPost]
		public IActionResult Edit(BookType bookType) 
		{
			repository.Update(bookType);
			return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
		}
		public IActionResult Delete(int id) 
		{
            repository.SpeacialDelete(id);
			return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });

		}
		 
	}
}
		