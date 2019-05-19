using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface IMateriaService
    {
        Task<Materia[]> BuscarMateriaAsync(string nombre);
        Task<bool> AgregarMateriaAsync(Materia NuevoMateria);
    }
}