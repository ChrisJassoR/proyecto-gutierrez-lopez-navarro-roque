using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Competencia
    {
        [Key]
        public int competenciaClave { get; set; }
        public string competencia { get; set; }
        
        List<Trabajo> Trabajos { get; set; }
        public int tipoClave { get; set; }
        public Tipo Tipo { get; set; }
    }
}