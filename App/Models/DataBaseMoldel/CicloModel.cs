using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Ciclo
    {
        [Key]
        public string cicloClave { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}