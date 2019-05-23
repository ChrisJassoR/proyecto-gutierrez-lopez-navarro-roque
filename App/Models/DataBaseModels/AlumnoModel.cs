using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Alumno
    {
        public int alumnoId { get; set; }
        [DisplayName("Nombre o nombres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string nombre { get; set; }
        [DisplayName("Apellido Paterno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidoPaterno { get; set; }
        [DisplayName("Apellido Materno")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
        public string apellidoMaterno { get; set; }

        public List<Calificacion> Calificaciones { get; set; }
        public List<ActividadAlumno> ActividadAlumnos { get; set; }
    }
}