using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App.Models.DataBaseModel;
using App.Areas.Identity.Data;
namespace App.Data
{
    public class ApplicationDbContext : IdentityDbContext<Hoja_de_CotejoUser>
    {
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Competencia> Competencias { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }  
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoActividad> CursoActividades { get; set; }
        public DbSet<ActividadAlumno> ActividadAlumnos { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        
    }
    
}
