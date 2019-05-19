using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface IAlumnoService
    {
        Task<Alumno[]> GetIncompleteItemsAsync();
        Task<bool> AgregarAlumnoAsync(Alumno NuevoAlumno);
        Task<bool> ModificarAlumnoAsync(Alumno ModificarAlumno);
        Task<bool> EliminarAlumnoAsync(int alumnoId);
    }
}