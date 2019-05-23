using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Calificacion
    {
        [Key]
        public int calificacionClave { get; set; }
        [DisplayName("Aprobado")]
        public bool aprobado {get; set; }

        [DisplayName("Alumno")]
        public int alumnoId { get; set; }
        public Alumno Alumno { get; set; }

        [DisplayName("Curso")]
        public string cursoClave { get; set; }
        public Curso Cursos { get; set; }
    }  
}