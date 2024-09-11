using Microsoft.AspNetCore.Mvc;
using ShortProject.Models;
using ShortProject.RepositoryPattern;

namespace ShortProject.Controllers
{
    public class UserController : Controller
    {
        private UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        public ActionResult Register(string name, string email)
        {
            User newUser = new User
            {
                Name = name,
                Email = email
            };

            userRepository.Add(newUser);

            return RedirectToAction("ViewUser", new { id = newUser.Id });
        }

        public ActionResult UserView(int id)
        {
            User user = userRepository.GetById(id);
            return View(user);
        }


    }
}
