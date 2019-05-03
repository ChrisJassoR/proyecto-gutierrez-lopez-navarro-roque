using Microsoft.EntityFrameworkCore;
using system;
using System.Collections.Generic;

namespace HOJA_DE_COTEJO
{
    public class Alumno
    {
      public int AlumnoId {get; set;}
      public string Nombre {get; set;}
      public string Carrera {get; set;}
      public int Grado {get; set;}
      public string Grupo {get; set;}
      public string Turno {get; set;}
      public int NumeroActividad {get; set;}
       
    }
    public class Profesor
    {
     public int ProfesorId {get; set;}
     public int NombreProfesor {get; set;}

    }
   public class Materia
   {
       public int MateriaId {get; set;}
       public string NombreMateria {get; set;}

   } 
   public class Competencias 
   {
       public int CompetenciaId {get; set;}
       public string TipoCompetencia {get; set;}
       public string DescripcionCompetencia {get; set;}
   }
   public class Actividades 
   {
       public int ActividadId {get; set;}
       public int PuntajeActividad {get; set;}
       public DateTime Entrega {get; set;}
       public int PuntajeObtenido {get; set;}
       
   }
}