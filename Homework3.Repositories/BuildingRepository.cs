using Homework3.DAL.Contexts;
using Homework3.DAL.Domain;
using Homework3.Models.DTO;
using Homework3.Repositories.Interfaces;
using AutoMapper;

namespace Homework3.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Здание.
    /// </summary>
    public class BuildingRepository : BaseRepository<BuildingDTO, Building>, IBuildingRepository
    {
        public BuildingRepository(Homework3Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
