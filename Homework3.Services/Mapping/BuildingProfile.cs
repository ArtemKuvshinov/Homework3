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
            CreateMap<Building, BuildingDTO>()
                .ForMember(x=>x.Address, x=>x.MapFrom(m=>"Улица "+m.Street+" №"+m.Number))
                .ForMember(x => x.Purpose, x => x.MapFrom(m => m.Purpose))
                .ForMember(x => x.NumberOfFloors, x => x.MapFrom(m => m.NumberOfFloors))
                .ForMember(x => x.Square, x => x.MapFrom(m => m.Square))
                .ForMember(x => x.CadastralNumber, x => x.MapFrom(m => m.CadastralNumber));
        }



    }
}
