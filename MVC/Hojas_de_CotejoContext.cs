using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MVC.Models;

namespace MVC
{
    public class Hojas_de_CotejoContext : DbContext
    {
        public DbSet <Alumno> Alumno { get; set; }
        public DbSet <Profesor> Profesor { get; set; }
        public DbSet <Materia> Materia { get; set; }
        public DbSet <Competencias> Competencias { get; set; }
        public DbSet <Actividades> Actividades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Hojas_de_Cotejo;user=Admin;password=Admin");
        }
    }
}