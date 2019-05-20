using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface IAlumnoService
    {
        Task<Alumno[]> BuscarAlumnoAsync(string nombre);
        Task<bool> AgregarAlumnoAsync(Alumno NuevoAlumno);
        Task<bool> ModificarAlumnoAsync(int alumnoId, string nombre);
        Task<bool> EliminarAlumnoAsync(int alumnoId);
    }
}