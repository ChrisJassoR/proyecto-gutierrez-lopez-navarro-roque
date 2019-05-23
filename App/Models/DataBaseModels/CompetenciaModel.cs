using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Competencia
    {
        [Key]
        public int competenciaClave { get; set; }
        [DisplayName("Competencia")]
        [DataType(DataType.Text)]
        public string descripcion { get; set; }
        
        List<Trabajo> Trabajos { get; set; }

        [DisplayName("Tipo de Competencia")]
        public int tipoClave { get; set; }
        public Tipo Tipo { get; set; }
    }
}