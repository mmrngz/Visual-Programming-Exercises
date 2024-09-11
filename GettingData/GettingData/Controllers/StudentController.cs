using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
	public class StudentController : Controller
	{
		List<Student> students=new List<Student>()
		{
			new Student(){firstName="Muhammet",lastName="Marangoz"},
			new Student(){firstName="Muhammet12313",lastName="Marangoz213123"},
			new Student(){firstName="Muhammet2334345",lastName="Marangoz132312"},
			new Student(){firstName="Muhammet436647",lastName="Marangoz231355"},
		};

		public IActionResult GetStudentList()
		{
			return View(students);
		}
		[HttpPost]
		public IActionResult  AddStudent(Student student)
		{
			students.Add(student);
			return View("GetStudentList",students);	
		}
	}
}
