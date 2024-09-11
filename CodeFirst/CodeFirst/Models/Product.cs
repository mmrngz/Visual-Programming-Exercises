using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Product :BaseEntity
    {
        public string ProductName { get; set; } 
        public decimal? UnitPrice { get; set; } 
        public short UnitsInStock { get; set; } 

        public int CategoryID { get; set; }     

       public virtual Category Category { get; set; }   

        public List<OrderDetail> OrderDetails { get; set; }  
       



    }
}
