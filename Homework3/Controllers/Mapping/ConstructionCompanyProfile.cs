using AutoMapper;
using Homework3.Models.DTO;
using Homework3.Models.Requests.ConstructionCompany;
using Homework3.Models.Responses.ConstructionCompany;

namespace Homework3.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Застройщик".
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>.
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<CreateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<UpdateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<ConstructionCompanyDTO, ConstructionCompanyResponse>();
        }
    }
}
