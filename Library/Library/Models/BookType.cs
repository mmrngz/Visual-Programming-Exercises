using Library.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        
        public string Name { get; set; }

        public List<Book> Books { get; set;} 

    }
}
