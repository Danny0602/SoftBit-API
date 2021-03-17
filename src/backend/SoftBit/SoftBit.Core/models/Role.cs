using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SoftBit.Core.models
{
    public class Role
    {
        /*codigo de id rol*/
        [Key]
        public int Id { get; set; }

        /*codigo de  nombre del rol*/
        [Required(ErrorMessage="The field is requiered")]
        [StringLength(40, ErrorMessage="The field rolename must have mas length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage="The field Rolename must be a string")]
        public String Rolename { get; set; }

        /*codigo descripcion*/
        [Required(ErrorMessage="The field descrption is required")]
        [StringLength(256,ErrorMessage="Thel field Description mus have max length of 200 characters")]
        public String Description { get; set; }


        public virtual ICollection<User> Users {get; set;}




    }
}