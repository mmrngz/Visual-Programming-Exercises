using HelloWorld2Real.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld2Real.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Muhammet";
            user.LastName = "Marangoz"; 
            return View();
        }
        [NonAction]// action olmadığını bildiriyor
        public string GetFullName(User user) 
        { 
            return user.FirstName + " " + user.LastName;
        }
    }
}
