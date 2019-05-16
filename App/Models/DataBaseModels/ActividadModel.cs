using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Actividad
    {
        [Key]
        public int actividadClave { get; set; }
        public string nombreActidad { get; set; }
        public int puntaje { get; set; } 

        public List<Trabajo> Trabajos { get; set; }
        public List<CursoActividad> CursoActividades { get; set; }
    }
}