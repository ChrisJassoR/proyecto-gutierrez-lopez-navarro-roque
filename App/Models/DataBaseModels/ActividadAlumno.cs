using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class ActividadAlumno
    {
        [Key]
        public int actividadalumnoClave { get; set; }
        
        public int cursoactividadClave { get; set; }
        public CursoActividad CursoActividad { get; set; }
        public int alumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }
}