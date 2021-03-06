using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Tipo
    {
        [Key]
        public int tipoClave { get; set; }
        public string nombre { get; set; }

        public List<Competencia> Competencia { get; set; }
    }
}