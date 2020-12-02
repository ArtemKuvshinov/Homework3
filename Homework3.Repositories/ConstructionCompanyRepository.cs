using Homework3.DAL.Domain;
using Homework3.Models.DTO;
using Homework3.Repositories.Interfaces;
using AutoMapper;
using Homework3.DAL.Contexts;

namespace Homework3.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Застройщик.
    /// </summary>
    public class ConstructionCompanyRepository : BaseRepository<ConstructionCompanyDTO, ConstructionCompany>, IConstructionCompanyRepository
    {
        public ConstructionCompanyRepository(Homework3Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
