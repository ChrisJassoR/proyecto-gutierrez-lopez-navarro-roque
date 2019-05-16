using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models.DataBaseModel
{
    public class Alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }

        public List<Calificacion> Calificaciones { get; set; }
        public List<ActividadAlumno> ActividadAlumnos { get; set; }
    }
}