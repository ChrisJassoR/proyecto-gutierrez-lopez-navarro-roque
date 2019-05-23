using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Profesor
    {
        public int profesorId { get; set; }
        [DisplayName("Nombre o nombres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string nombre { get; set; }
        [DisplayName("Apellido Paterno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidopaterno { get; set; }
        [DisplayName("Apellido Materno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidomaterno { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}