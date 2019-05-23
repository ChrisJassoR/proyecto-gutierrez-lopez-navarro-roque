using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class CursoActividad
    {
        [Key]
        public int cursoactividadClave { get; set; }
        [DisplayName("Fecha de entrega")]
        public DateTime fechaEntrega {get; set; }
        
        public List<ActividadAlumno> ActividadAlumnos { get; set; }
        
        public int actividadClave { get; set; }
        public Actividad Actividad { get; set; }
        public int cursoClave { get; set; }
        public Curso Curso { get; set; }
    }
}