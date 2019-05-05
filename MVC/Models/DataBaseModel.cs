using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    //falta referencia en Db
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Grado { get; set; }
        public string Grupo { get; set; }
        public string Turno { get; set; }

    }
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        public int NombreProfesor { get; set; }
        public List<Materia> Materias { get; set; }

    }
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public Profesor Profesor { get; set; }
        public Actividades Actividades { get; set; }

    }
    public class Competencias
    {
        [Key]
        public int CompetenciaId { get; set; }
        public string TipoCompetencia { get; set; }
        public string DescripcionCompetencia { get; set; }
    }
    public class Actividades
    {
        [Key]
        public int ActividadId { get; set; }
        public int PuntajeActividad { get; set; }
        public DateTime Entrega { get; set; }
        public int PuntajeObtenido { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Competencias> Competencias { get; set; }
    }
}