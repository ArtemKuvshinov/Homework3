using AutoMapper;
using Homework3.DAL.Domain;
using Homework3.Models.DTO;

namespace Homework3.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (здание).
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<Building, BuildingDTO>().ReverseMap();
        }
    }
}
