using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Library.Controllers
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
            if (repository1.Any(x=>x.UserName== user.UserName && x.Status !=Enums.DataStatus.Deleted))
            {
                AppUser selectuser = repository1.Default(x=>x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted);
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
                    if (selectuser.Role == Enums.Role.admin)
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

