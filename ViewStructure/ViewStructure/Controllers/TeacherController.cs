using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
	public class TeacherController : Controller
	{
		List<Teacher> teachers = new List<Teacher>() 
		{
			new Teacher(){id = 1,name="Muhammet",gender="man"},
			new Teacher(){id = 2,name="Ada",gender="woman"},
			new Teacher(){id = 3,name="Ebu",gender="man"},
			new Teacher(){id = 4,name="Tugce",gender="woman"},
		};	

		public IActionResult GetTeacherList()
		{
			return View(teachers);
		}
		public IActionResult DeleteTeacher(int id)
		{
			Teacher teacher= teachers.Find(x => x.id == id);
			return View(teacher);
		}
	}
}
