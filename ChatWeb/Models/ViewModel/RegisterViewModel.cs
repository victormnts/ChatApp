using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatWeb.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name="Nombre")]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Ciudad")]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Compare("Password")]
        [Display(Name = "Confirmar Contraseña")]
        public string Password2 { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }
    }
}