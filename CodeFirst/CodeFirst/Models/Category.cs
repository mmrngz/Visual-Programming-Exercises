using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Category :BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

     public  List<Product> Products { get; set; }   


     

    }
}
