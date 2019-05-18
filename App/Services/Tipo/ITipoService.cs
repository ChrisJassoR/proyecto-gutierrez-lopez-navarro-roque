using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface ITipoService
    {
        Task<Tipo[]> GetIncompleteItemsAsync();
        Task<bool> AgregarTipoAsync(Tipo NuevoTipo);
    }
}