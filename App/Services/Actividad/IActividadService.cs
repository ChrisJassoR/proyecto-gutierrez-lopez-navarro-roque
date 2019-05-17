using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Models.DataBaseModel;
namespace App.Services
{
    public interface IActividadService
    {
        Task<Actividad[]> GetIncompleteItemsAsync();
    }
}