using Microsoft.AspNetCore.Mvc;
using MvcProject.MODEL.Models.MetaDataTypes;
using System.Collections.Generic;

namespace MvcProject.MODEL.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        
        public string Name { get; set; }

        public List<Book> Books { get; set;} 

    }
}
