using System.Collections.Generic;

namespace MvcProject.MODEL.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }       
        public string LastName { get; set; }
        public string SchoolNumber { get; set; }
        
        public virtual StudentDetail StudentDetail { get; set; }
        
        public List<Operation> Operations { get; set; }

    }
}
