using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Ciclo
    {
        [Key]
        public string cicloClave { get; set; }
        [DisplayName("Incicio")]
        [DataType(DataType.Date)]
        public DateTime inicio { get; set; }
        [DisplayName("Fin")]
        [DataType(DataType.EmailAddress)]
        public DateTime fin { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}