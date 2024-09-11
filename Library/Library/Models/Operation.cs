using System;

namespace Library.Models
{
    public class Operation :BaseEntity
    {
        public int BookID { get; set; } 
        public int StudentID { get; set; }  

        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }

        public virtual Student Student { get; set; }    
        public virtual Book Book { get; set; }  

    }
}
