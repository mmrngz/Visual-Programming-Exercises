using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
                new User(){FirstName="Muhammet",LastName="Marangoz"},
                new User(){FirstName="Microsoft",LastName=".NetCore"},
                new User(){FirstName="Aysenur",LastName="Kocak"},
            };
        public IActionResult UseViewBag()
        {
           
            ViewBag.UserName = "MUHAMMET";
            User user = new User();
            user.FirstName = "MARANGOZ";
            user.LastName = "MARANGOZ 2";
            ViewBag.User=user;
           
            ViewBag.Users=users;

            return View();
        }
        public IActionResult UseViewData() 
        {
            ViewData["UserName"] = "Muhammet1";  //Viewbag dinamik veri tutarken view data da object veri tutuyoruz

            User user= new User();
            user.FirstName = "MUHAMMET";
            user.LastName = "MARANGOZ";
            ViewData["User"] = user;
            ViewData["Users"] = users;
            return View();
        }
        public IActionResult UseTempData()
        {
            TempData["Name"] = "Muhsdadsammet";

            return RedirectToAction("TempDataTest"); // Tempdatatest sayfasına aktarımı sağlıyor
        }
        public IActionResult TempDataTest()
        {
            TempData.Keep("Name");  // uzatıyor
            string userName = TempData["Name"].ToString();
            return View();
        }
	}
} 
