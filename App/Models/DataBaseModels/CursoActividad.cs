using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class CursoActividad
    {
        [Key]
        public int cursoactividadClave { get; set; }
        public DateTime fecha_entrega {get; set; }
        
        public List<ActividadAlumno> ActividadAlumnoS { get; set; }
        public int actividadClave { get; set; }
        public Actividad Actividad { get; set; }
        public int cursoClave { get; set; }
        public Curso Curso { get; set; }
    }
}