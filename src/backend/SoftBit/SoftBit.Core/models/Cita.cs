using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftBit.Core.models
{
    public class Cita
    {
        /*id de la cita*/
        [Key]
        public int Id{get; set;}

        /*id del usuario*/
        [ForeignKey("User")]
        public int Id_user {get;set;}
        public virtual Cita cita{get; set;}

        /*dia de la cita*/
        [Required]    
         public string Dia{get;set;}

        /*hora de inicio*/
        [Required]    
         public string Hora_i{get;set;}
        /*hora de final*/
        [Required]    
         public string Hora_f{get;set;}

        /*Fecha de registro*/
        [Required]    
         public string Fecha_reg{get;set;}


    }
}