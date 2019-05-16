using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Trabajo
    {
        [Key]
        public int trabajoClave { get; set; }
        
        public int competenciaClave { get; set; }
        public Competencia Competencia { get; set; }
        public int actividadClave { get; set; }
        public Actividad Actividad { get; set; }
    }
}