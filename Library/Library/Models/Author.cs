using Library.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))] 
    public class Author : BaseEntity
    {
       
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }   

    }
}
