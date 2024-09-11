using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.DAL.Context;
using MvcProject.MODEL.Models;
using System.Collections.Generic;

namespace MvcProject.UI.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy ="AdminPolicy")]
    public class AuthorController : Controller
	{
		MyDbContext _db;
		IAuthorRepository rep;

        public AuthorController(MyDbContext myDbContext, IAuthorRepository repository)
        {
			_db = myDbContext;	
			rep = repository;
		}


        public IActionResult AuthorList()
		{
			List<Author> authors= rep.GetActives();	
			return View(authors);
		}
		public IActionResult Create()
		{ 
			return View();
        }
		[HttpPost]	
        public IActionResult Create(Author author)
        {
			if (!ModelState.IsValid)
			{
				return View(author);	
			}
			rep.Add(author);
            return RedirectToAction("AuthorList","Author",new { area= "Management"});
        }
		public IActionResult Edit(int id) 
		{
			Author author = rep.GetById(id);
			return View(author);
		}
		[HttpPost]
		public IActionResult Edit(Author author) 
		{
			rep.Update(author);
			return RedirectToAction("AuthorList", "Author", new { area = "Management" });
		}
		public IActionResult Delete(int id) 
		{
			rep.Delete(id);
			return RedirectToAction("AuthorList", "Author", new { area = "Management" });
		}
    }
}
