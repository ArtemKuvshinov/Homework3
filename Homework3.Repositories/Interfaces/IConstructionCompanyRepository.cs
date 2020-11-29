using Homework3.DAL.Domain;
using Homework3.Models.DTO;
using Homework3.Repositories.Interfaces.CRUD;

namespace Homework3.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для с объектами Застройщик.
    /// </summary>
   public interface IConstructionCompanyRepository : ICrudRepository<ConstructionCompanyDTO, ConstructionCompany>
    {
    }
}
