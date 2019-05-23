using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Curso
    {
        [Key]
        public int cursoClave { get; set; }
        
        public List<CursoActividad> CursoActividades { get; set; }
        public List<Calificacion> Calificacion { get; set; }

        [DisplayName("Ciclo")]
        public string cicloClave { get; set; }
        public Ciclo Ciclo { get; set; }

        [DisplayName("Materia")]
        public int materiaClave { get; set; }
        public Materia Materia { get; set; }

        [DisplayName("Profesor")]
        public int profesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
}