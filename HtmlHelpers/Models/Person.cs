using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpers.Models
{
    public class Person
    {
        [Required]
        [Display(Name ="Cédula")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Range(15,99)]
        [Display(Name = "Edad")]
        public int Age { get; set; }

        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Género")]
        public Gender Gender { get; set; }

        [Display(Name = "Estado Civil")]
        public string CivilStatus { get; set; }

       // [Display(Name = "Afición")]
      //  public string Hobby  { get; set; }
    }

    public enum Gender
    {
        M,
        F
    }
}
