using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace GettingData.Controllers
{
	public class TeacherController : Controller
	{
		List<Branch> branches = new List<Branch>() 
		{
			new Branch() {Id=1,branchName="Matematik"},
			new Branch() {Id=2,branchName="Fizik"},
			new Branch() {Id=3,branchName="Kimya"},
			new Branch() {Id=4,branchName="Biyoloji"},
		};

		public IActionResult AddTeacher()
		{
			ViewBag.Branches=branches;
			return View();
		}

		[HttpPost]
		public IActionResult AddTeacher(Teacher teacher)
		{
			ViewBag.Branches = branches;
			return View();
		}
		public IActionResult AddTeacherUsingTuple() 
		{
			(List<Branch>, Teacher, Student) tuple = (branches,new Teacher(),new Student());
			return View(tuple);
		}
		[HttpPost]
		public IActionResult AddTeacherUsingTuple([Bind(Prefix ="Item2")] Teacher teacher, [Bind(Prefix = "Item3")] Student student)	
		{
			return RedirectToAction("AddTeacherUsingTuple");
		}
	}
}
