using System.Collections.Generic;
using Homework2.Models.DTO;
using Homework2.DataBase.Domain;

namespace Homework2.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание".
    /// </summary>
   public interface IBuildingService
    {
        IEnumerable<BuildingDTO> GetBuildings();

        BuildingDTO GetBuilding(long id);

        long GetId(Building building);

        void DeleteBuilding(long id);

        void AddBuilding(Building newBuilding);

        void UpdateBuilding(Building building);

     
    }
}
