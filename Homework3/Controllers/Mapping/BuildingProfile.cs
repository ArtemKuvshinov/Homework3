using Homework3.Models.DTO;
using Homework3.Models.Requests.Building;
using Homework3.Models.Responses.Building;
using AutoMapper;

namespace Homework3.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Здание".
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>.
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<CreateBuildingRequest, BuildingDTO>();
            CreateMap<UpdateBuildingRequest, BuildingDTO>();
            CreateMap<BuildingDTO, BuildingResponse>();
        }
    }
}
