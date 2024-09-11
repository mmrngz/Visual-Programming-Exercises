using Library.Enums;
using Microsoft.AspNetCore.Identity;

namespace Library.Models
{
    public class AppUser: BaseEntity
    {
        public string UserName { get; set; }    
        public string Password { get; set; }    
        public Role Role { get; set; }  

    }
}
