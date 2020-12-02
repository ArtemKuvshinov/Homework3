using AutoMapper;
using Homework3.DAL.Domain;
using Homework3.Models.DTO;

namespace Homework3.Repositories.Mapping
{
    /// <summary>
    /// Профиль маппинга (Застройщик).
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<ConstructionCompany, ConstructionCompanyDTO>().ReverseMap();
        }
    }
}
