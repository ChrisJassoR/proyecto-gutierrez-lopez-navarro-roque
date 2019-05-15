using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace App.Models
{
    //clases independientes
    public class Carrera
    {
        [Key]
        public string carreraClave { get; set; }
        public string nombre { get; set; }

        public List <Materia> Materias { get; set; }
    }
    public class Profesor
    {
        public int profesorId { get; set; }
        public string nombre { get; set; }

        public List<Curso> Cursos { get; set; }
    }
    public class Ciclo
    {
        [Key]
        public string cicloClave { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }

        public List<Curso> Cursos { get; set; }
    }
    public class Alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }

        public List<Calificacion> Calificaciones { get; set; }
        public List<ActividadAlumno> ActividadAlumnos { get; set; }
    }
    public class Tipo
    {
        [Key]
        public int tipoClave { get; set; }
        public string nombre { get; set; }

        public List<Competencia> Competencia { get; set; }
    }
    public class Actividad
    {
        [Key]
        public int actividadClave { get; set; }
        public string nombreActidad { get; set; }
        public int puntaje { get; set; } 

        public List<Trabajo> Trabajos { get; set; }
        public List<CursoActividad> CursoActividades { get; set; }
    }
    //clases dependientes simples
    public class Materia
    {
        [Key]
        public string materiaClave { get; set; }
        public string Nombre { get; set; }
        
        List<Curso> Cursos { get; set; }
        public int carreraClave { get; set; }
        public Carrera Carrera { get; set; }
    } 
    public class Competencia
    {
        [Key]
        public int competenciaClave { get; set; }
        public string competencia { get; set; }
        
        List<Trabajo> Trabajos { get; set; }
        public int tipoClave { get; set; }
        public Tipo Tipo { get; set; }
    }
    //clases super dependientes
    public class Trabajo
    {
        [Key]
        public int trabajoClave { get; set; }
        
        public int competenciaClave { get; set; }
        public Competencia Competencia { get; set; }
        public int actividadClave { get; set; }
        public Actividad Actividad { get; set; }
    }
    //clases super dependientes
    public class Curso
    {
        [Key]
        public int cursoClave { get; set; }
        
        public List<CursoActividad> CursoActividades { get; set; }
        public List<Calificacion> Calificacion { get; set; }
        public int cicloClave { get; set; }
        public Ciclo Ciclo { get; set; }
        public int materiaClave { get; set; }
        public Materia Materia { get; set; }
        public int profesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
    public class CursoActividad
    {
        [Key]
        public int cursoactividadClave { get; set; }
        
        public List<ActividadAlumno> ActividadAlumnoS { get; set; }
        public int actividadClave { get; set; }
        public Actividad Actividad { get; set; }
        public int cursoClave { get; set; }
        public Curso Curso { get; set; }
    }
    public class ActividadAlumno
    {
        [Key]
        public int actividadalumnoClave { get; set; }
        
        public int cursoactividadClave { get; set; }
        public CursoActividad CursoActividad { get; set; }
        public int alumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }
    public class Calificacion
    {
        [Key]
        public int calificacionClave { get; set; }

        public int alumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int cicloClave { get; set; }
        public Ciclo Ciclo { get; set; }
    }
}                                           