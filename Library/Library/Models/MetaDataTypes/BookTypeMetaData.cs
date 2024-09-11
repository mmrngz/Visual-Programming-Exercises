using System.ComponentModel.DataAnnotations;

namespace Library.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Lutfen Doldurunuz!")]
        public string Name { get; set; }
    }
}
