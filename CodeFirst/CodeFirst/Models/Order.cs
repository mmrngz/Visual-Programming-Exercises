using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Order :BaseEntity
    {
        public int AppUserID { get; set; } 
        public virtual AppUser AppUser { get; set; } 

        public List<OrderDetail> OrderDetails { get; set; }
        
    }
}
