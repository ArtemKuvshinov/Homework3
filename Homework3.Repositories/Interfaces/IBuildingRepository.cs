using Homework3.DAL.Domain;
using Homework3.Models.DTO;
using Homework3.Repositories.Interfaces.CRUD;

namespace Homework3.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с объектами Здание.
    /// </summary>
    public interface IBuildingRepository : ICrudRepository<BuildingDTO, Building>
    {
    }
}
