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
        [Key]
        public string cicloClave { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
    }

    public class Alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }
    }
    public class Tipo
    {
        [Key]
        public int TipoClave { get; set; }
        public string nombre { get; set; }
    }
    public class Grado
    {

    }
    public class Grupo
    {

    }
    public class Actividad
    {

    }
    //clases dependientes simples
    
    public class Materia
    {
        public string materiaClave { get; set; }
        public string Nombre { get; set; }
        //falta referencia a Carrera 
    } 
    public class Competencia
    {
        public int competenciaId { get; set; }
        public string competencia { get; set; }
        //falta referencia a Tipo
    }
    //clases super dependientes
    public class Gg
    {
        //falta referencia a grado
        //falta referencia a grupo
    }
    public class Catalogo
    {
        //falta referencia a Materia
        //falta referencia a Profesor
    }
    public class Trabajo
    {
        //falta referencia a Competencia
        //falta referencia a Actividad
    }
    
    public class AlumnoCurso
    {
        //falta referencia Alumno
        //falta referencia Curso
    }
    //clases super dependientes
    public class Curso
    {
        //falta referencia a Catalogo
        //falta referencia a Ciclo
        //Gg
    }
    public class Cotejo
    {
        //falta referencia AlumnoCotejo
        //falta referencia Trabajo
    }

}                                           