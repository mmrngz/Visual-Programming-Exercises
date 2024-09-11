using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcProject.BLL.RepositoryPattern.Interfaces;
using MvcProject.MODEL.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcProject.UI.Controllers
{

    public class AuthController : Controller
    {
        IRepository<AppUser> repository1;
        public AuthController(IRepository<AppUser> repository) 
        {
            repository1 = repository;   
        } 
        public IActionResult Login()
        {
            return View();
        }


        //veritabanında ilgili kullancı var mı?
        //kullancı bilgilerini çekme
        //kullanıcının şifresi kriptolu şifre ile eşleşiyor mu kontrolü
        //kullanıcının rolüne göre sayfa yönlendirmesi
        [HttpPost]
        public async Task<IActionResult> Login(AppUser user)
        {
            if (repository1.Any(x=>x.UserName== user.UserName && x.Status !=MODEL.Enums.DataStatus.Deleted))
            {
                AppUser selectuser = repository1.Default(x=>x.UserName == user.UserName && x.Status != MODEL.Enums.DataStatus.Deleted);
                bool IsValid = BCrypt.Net.BCrypt.Verify(user.Password,selectuser.Password);
                if (IsValid) 
                {
                    List<Claim> claims=new List<Claim>()
                    {
                       new Claim("userName",selectuser.UserName),
                       new Claim("userId",selectuser.ID.ToString()),
                       new Claim("role",selectuser.Role.ToString())

                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (selectuser.Role == MODEL.Enums.Role.admin)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Management" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }


            }

            return View();
        }
        public async Task<IActionResult> LogOut() 
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login","Auth",null);
        }


    }
}

