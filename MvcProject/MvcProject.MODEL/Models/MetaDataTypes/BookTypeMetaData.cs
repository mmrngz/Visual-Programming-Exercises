using System.ComponentModel.DataAnnotations;

namespace MvcProject.MODEL.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Lutfen Doldurunuz!")]
        public string Name { get; set; }
    }
}
