using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class RegisterCount
    {
        [Key]
        public string code { get; set; }
        public int numberCode { get; set; }
        public int alumnoId{ get; set; }
        public Alumno Alumno { get; set; }
        public int profesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
}
