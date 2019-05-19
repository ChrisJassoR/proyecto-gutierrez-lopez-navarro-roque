using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface ICicloService
    {
        Task<Ciclo[]> BuscarCicloAsync(string nombre);
        Task<bool> AgregarCicloAsync(Ciclo NuevoCiclo);
    }
}