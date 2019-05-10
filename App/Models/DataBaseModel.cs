using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace App.Models
{
    //clases independientes
    public class Carrera
    {
        [Key]
        public string carreraClave { get; set; }
        public string nombre { get; set; }
    }
    public class Profesor
    {
        public int profesorId { get; set; }
        public string nombre { get; set; }
    }
    public class Ciclo
    {
        public string cicloClave { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
    }

    public class Alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }
    }







    //clases dependientes simples
    public class Materia
    {
        public string materiaClave { get; set; }
        public string Nombre { get; set; }

        //falta referencia a Carrera
    }
}
