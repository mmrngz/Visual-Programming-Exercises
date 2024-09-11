using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller 
    {
        public string Index() // controller
        {
            return "uygulama calisiyor.."; //action 
            
        }
        public string Test()
        {
            return "bu test actionidir";
        }
    }
}
