using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Profesor
    {
        public int profesorId { get; set; }
        public string nombre { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}