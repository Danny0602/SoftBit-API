using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftBit.Core.models
{
    /*tabla de usuarios*/
    public class User
    {   
        /*Id del usuarios - primary key*/
        [Key]
        public int Id { get; set;}


        
        /*columna del nombre*/
        [Required(ErrorMessage = "Name required")]
        [StringLength(50, ErrorMessage = "Name is bad")]
        [DataType(DataType.Text, ErrorMessage = "Name is not text")]
        public String Name {get;set;}

        /*columna del E-mail*/
        [Required(ErrorMessage = "E-mailrequired")]
        [StringLength(50, ErrorMessage = "E-mail is bad")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not text")]
        public String Email {get;set;}

        /*columna de contraseña-password*/
        [Required(ErrorMessage = "Password required")]
        [StringLength(256, ErrorMessage = "password is bad")]
        [DataType(DataType.Text, ErrorMessage = "password is not text")]
        public String Password { get; set; }

        /*columna de matricula*/
        [Required(ErrorMessage = "Matricula required")]
        [StringLength(10, ErrorMessage = "Matricula is bad")]
        [DataType(DataType.Text, ErrorMessage = "Matricula is not text")]
        public String Matricula { get; set; }

        

        /*codigo de rol id*/
        [ForeignKey("Role")]
       
        [Range(0,int.MaxValue, ErrorMessage="")]
        public int RoleId { get; set; }
        public virtual Role Role {get; set;}
        public virtual ICollection<Cita> Citas {get; set;}

        public User(){
            this.RoleId  = 2;
        }
        
    }
}