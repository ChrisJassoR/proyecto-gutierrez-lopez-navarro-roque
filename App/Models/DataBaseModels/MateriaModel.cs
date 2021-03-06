using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Materia
    {
        [Key]
        public int materiaClave { get; set; }
        public string Nombre { get; set; }
        
        List<Curso> Cursos { get; set; }
        List<Actividad> Actividades { get; set; }
        public string carreraClave { get; set; }
        public Carrera Carrera { get; set; }
    } 
}