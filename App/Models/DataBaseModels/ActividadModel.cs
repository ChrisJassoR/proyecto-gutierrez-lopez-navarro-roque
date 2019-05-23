using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Actividad
    {
        [Key]
        public int actividadClave { get; set; }
        [DisplayName("Actividad")]
        public string nombreActidad { get; set; }
        [DisplayName("Valor")]
        public int puntaje { get; set; }

        public List<Trabajo> Trabajos { get; set; }
        public List<CursoActividad> CursoActividades { get; set; }

        [DisplayName("Materia")]
        public int materiaClave { get; set; }
        public Materia Materia { get; set; }
    }
}