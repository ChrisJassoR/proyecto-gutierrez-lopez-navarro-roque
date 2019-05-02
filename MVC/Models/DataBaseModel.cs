using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Alumno
    {
        public int Alumnoid { get; set; }

    }
    public class Materia
    {
        public int Materiaid { get; set; }
        
    }
    public class Profesor
    {
        public int Profesorid { get; set; }
        [Required]
        public string Nombre { get; set; }
        
    }
    public class Actividad
    {
        public int Actividadid { get; set; }
        
    }
    public class Competencia
    {
        public int Competenciaid { get; set; }
        
    }
}