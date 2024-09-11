using MvcProject.MODEL.Enums;

namespace MvcProject.MODEL.Models
{
    public class AppUser: BaseEntity
    {
        public string UserName { get; set; }    
        public string Password { get; set; }    
        public Role Role { get; set; }  

    }
}
