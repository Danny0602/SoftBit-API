using System.ComponentModel.DataAnnotations;

namespace SoftBit.Core.models
{
    public class Mensajes
    {
        [Key]
        public int ID {get;set;}


        [Required(ErrorMessage = "Name required")]
        [StringLength(50, ErrorMessage = "Name is bad")]
        [DataType(DataType.Text, ErrorMessage = "Name is not text")]
        public string Nombre{get;set;}

        public string Telefono{get;set;}

        [Required(ErrorMessage = "text required")]
        [StringLength(250, ErrorMessage = "text is bad")]
         public string Mensaje{get;set;}
    }
}