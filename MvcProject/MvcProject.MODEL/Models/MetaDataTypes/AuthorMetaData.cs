using System.ComponentModel.DataAnnotations;

namespace MvcProject.MODEL.Models.MetaDataTypes
{
    public class AuthorMetaData
    {
       
        [MaxLength(15, ErrorMessage = "Lütfen 15 den az deger giriniz")]
        public string FirstName { get; set; }
    }
}
