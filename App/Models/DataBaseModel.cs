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

        public int materiaClave { get; set; }
        public Materia Materia { get; set; }
    }
    public class Profesor
    {
        public int profesorId { get; set; }
        public string nombre { get; set; }

        public int CursoClave { get; set; }
        public Curso Curso { get; set; }
    }
    public class Ciclo
    {
        [Key]
        public string cicloClave { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }

        public int cicloClave { get; set; }
        public Curso Curso { get; set; }
    }
    public class Alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }

        public int calificacionClave { get; set; }
        public Calificacion Calificacion { get; set; }

        public int actividadalumnoClave { get; set; }
        public ActividadAlumno ActividadAlumno { get; set; }
    }
    public class Tipo
    {
        [Key]
        public int tipoClave { get; set; }
        public string nombre { get; set; }

        public int competenciaClave { get; set; }
        public Competencia Competencia { get; set; }
    }
    public class Actividad
    {
        [Key]
        public int actividadClave { get; set; }
        public string nombreActidad { get; set; }
        public int puntaje { get; set; } 

        public int trabajoClave { get; set; }
        public Trabajo Trabajo { get; set; }

        public int cursoactividadClave { get; set; }
        public CursoActividad CursoActividad { get; set; }
    }
    //clases dependientes simples
    public class Materia
    {
        [Key]
        public string materiaClave { get; set; }
        public string Nombre { get; set; }
        //falta referencia a Carrera
        List<Carrera> Carreras { get; set; }

        public int Cursoclave { get; set; }
        public Curso Curso { get; set; }
    } 
    public class Competencia
    {
        [Key]
        public int competenciaClave { get; set; }
        public string competencia { get; set; }
        //falta referencia a Tipo
        List<Tipo> Tipos { get; set; }

        public int trabajoClave { get; set; }
        public Trabajo Trabajo { get; set; }
    }
    //clases super dependientes
    public class Trabajo
    {
        [Key]
        public int trabajoClave { get; set; }
        //falta referencia a Competencia
        //falta referencia a Actividad
        public List<Competencia> Competencias { get; set; }
        public List<Actividad> Actividades { get; set; }
    }
    //clases super dependientes
    public class Curso
    {
        [Key]
        public int cursoClave { get; set; }
        //falta referencia a Materia
        //falta referencia a Ciclo
        //Falta referencia a Profesor
        public List<Materia> Materias { get; set; }
        public List<Ciclo> Ciclos { get; set; }
        public List<Profesor> Profesores { get; set; }

        public int calificacionClave { get; set; }
        public Calificacion Calificacion { get; set; }

        public int cursoactividadClave { get; set; }
        public CursoActividad CursoActividad { get; set; }
    }
    public class CursoActividad
    {
        [Key]
        public int cursoactividadClave { get; set; }
        //falta refencia a actividad
        //fata referencia a curso
        public List<Actividad> Actividades { get; set; }
        public List<Curso> Cursos { get; set; }

        public int actividadalumnoClave { get; set; }
        public ActividadAlumno ActividadAlumno { get; set; }
    }
    public class ActividadAlumno
    {
        public int actividadalumnoClave { get; set; }
        //falta referencia a alumno
        //falta referencia a cursoactividad
        public List<Alumno> Alumnos { get; set; }
        public List<CursoActividad> CursoActividades { get; set; }
    }
    public class Calificacion
    {
        public int calificacionClave { get; set; }
        //falta referencia a curso
        //falta referencia a alumno
        public List<Curso> Cursos { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}                                           