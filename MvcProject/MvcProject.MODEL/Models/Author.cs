using Microsoft.AspNetCore.Mvc;
using MvcProject.MODEL.Models.MetaDataTypes;
using System.Collections.Generic;

namespace MvcProject.MODEL.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))] 
    public class Author : BaseEntity
    {
       
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }   

    }
}
