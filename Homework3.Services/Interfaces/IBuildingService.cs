using System.Collections.Generic;
using Homework3.Models.DTO;
using Homework3.DAL.Domain;

namespace Homework3.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание".
    /// </summary>
    public interface IBuildingService : ICrudService<BuildingDTO>
    {
    }
}
