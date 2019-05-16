using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Carrera
    {
        [Key]
        public string carreraClave { get; set; }
        public string nombre { get; set; }

        public List <Materia> Materias { get; set; }
    }
}