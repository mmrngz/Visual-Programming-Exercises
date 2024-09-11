using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Concrete;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookController : Controller
	{
        
        MyDbContext db; 
		IBookRepository repository;
		IAuthorRepository authorRepository;
		IBookTypeRepository bookTypeRepository;
		public BookController(MyDbContext myDbContext, IBookRepository bookRepository, IAuthorRepository authorrep,IBookTypeRepository bookTypeRep)
		{
			db = myDbContext;
			repository = bookRepository;
			authorRepository = authorrep;
			bookTypeRepository = bookTypeRep;
		}
		public IActionResult BookList()
		{
			List<Book> books = repository.GetBooks();
			return View(books);
		}
		public IActionResult Create() 
		{
			List<AuthorDto> authors = authorRepository.GetAuthorDtos();

			List<BookTypeDto> bookTypes = bookTypeRepository.GetsBookTypeDtos();
			return View((new Book(),authors,bookTypes));
		}
		[HttpPost]
		public IActionResult Create([Bind(Prefix ="Item1")] Book book) 
		{
			if (!ModelState.IsValid)
			{
                List<AuthorDto> authors = authorRepository.GetAuthorDtos();

                List<BookTypeDto> bookTypes = bookTypeRepository.GetsBookTypeDtos();
				return View((book, authors, bookTypes));
            }
            repository.Add(book);
			return RedirectToAction("BookList", "Book", new { area = "Management" });	
		}
		public IActionResult Edit(int id) 
		{
			Book book = repository.GetById(id);
			List<AuthorDto> authors=authorRepository.GetAuthorDtos();	
			List<BookTypeDto> bookTypes =bookTypeRepository.GetsBookTypeDtos();	
			
			return View((book,authors,bookTypes));	
		}
		[HttpPost]
		public IActionResult Edit([Bind(Prefix ="Item1")] Book book)
		{
			if(book != null) 
			{
				repository.Update(book);

			}
			return RedirectToAction("BookList", "Book", new { area = "Management" });	
		}
		public IActionResult Delete(int id) 
	    {
			repository.SpeacialDelete(id);	
			return RedirectToAction("BookList", "Book", new { area = "Management" });

		}
    }
}