namespace CodeFirst.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; } 
        public decimal? TotalPrice { get; set; }    
        
        public int OrderID { get; set; }    
        public int ProductID { get; set; }  


        public virtual Product Product { get; set; }   
        public virtual Order Order { get; set; }
    }
}
