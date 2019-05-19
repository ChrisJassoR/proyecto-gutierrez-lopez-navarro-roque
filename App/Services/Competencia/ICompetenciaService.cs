using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface ICompetenciaService
    {
        Task<Competencia[]> BuscarCompetenciaAsync(string nombre);
        Task<bool> AgregarCompetenciaAsync(Competencia NuevoCompetencia);
    }
}