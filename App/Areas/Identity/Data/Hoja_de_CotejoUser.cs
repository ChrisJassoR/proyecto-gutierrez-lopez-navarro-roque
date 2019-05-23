using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Areas.Identity.Data
{
    public class Hoja_de_CotejoUser : IdentityUser
    {
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidoPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidoMaterno { get; set; }
        [Display(Name = "Tipo de Persona")]
       
        public string Persona { get; set; }
    }
}