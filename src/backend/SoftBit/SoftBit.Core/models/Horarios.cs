using System.ComponentModel.DataAnnotations;

namespace SoftBit.Core.models
{
    public class Horarios
    {
        /*id del dia de horarios*/
        [Key]
        public int Id{get;set;}

        public string Dia{get;set;}

        /*abierto desde*/
        public string Desde{get;set;}

        /*abierto hasta*/
        public string hasta{get;set;}
    }
}