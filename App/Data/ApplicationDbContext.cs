using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        //falta terminar dependecias(llaves foraneas)
        /*
        public DbSet<Materia> Materias { get; set; } 
        */
    }
}
