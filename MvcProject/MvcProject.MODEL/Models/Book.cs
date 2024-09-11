using System.Collections.Generic;

namespace MvcProject.MODEL.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string PageCount { get; set; }

        public int AuthorID { get; set; }
        public int BookTypeID { get; set; }


        public virtual Author Author { get; set; }
        public virtual BookType BookType { get; set; }

        public List<Operation> Operations { get; set; }


    }
}
