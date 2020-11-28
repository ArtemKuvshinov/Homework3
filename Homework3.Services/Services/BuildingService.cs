using System;
using System.Collections.Generic;
using System.Text;
using Homework2.Models.DTO;
using Homework2.Services.Interfaces;
using AutoMapper;
using Homework2.DataBase.Mocks;
using Homework2.DataBase.Domain;
using System.Linq;

namespace Homework2.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными "Здание".
    /// </summary>
    /// <inheritdoc cref="IBuildingService"/>
    public class BuildingService : IBuildingService
    {
        private List<Building> _listBuilding;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// Пооключение автомаппера через DI.
        /// </summary>
        /// <param name="mapper"></param>
        public BuildingService(IMapper mapper)
        {
            _mapper = mapper;
            _listBuilding = BuildingMock.GetBuilding().ToList<Building>();
        }

        /// <summary>
        /// Получет коллекцию объектов BuildingDTO.
        /// </summary>
        /// <returns>Коллекция объектов BuildingDTO</returns>
        public IEnumerable<BuildingDTO> GetBuildings()
        {
            var buildings = _listBuilding;
            var response = _mapper.Map<IEnumerable<BuildingDTO>>(buildings);
            return response;
        }

        /// <summary>
        /// Получает объект "Здание".
        /// </summary>
        /// <param name= "id"> Идентификатор записи</param>
        /// <returns>Объект BuildingDTO</returns>
        public BuildingDTO GetBuilding(long id)
        {
            Building build = _listBuilding.Where(x => x.Id == id).FirstOrDefault<Building>();
            BuildingDTO result = _mapper.Map<BuildingDTO>(build);
            return result;
        }

        /// <summary>
        /// Удаляет запись по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        public void DeleteBuilding(long id)
        {
            _listBuilding.Remove(_listBuilding.Where(x => x.Id == id).FirstOrDefault<Building>());
        }

        /// <summary>
        /// Добавляет новое здание.
        /// </summary>
        /// <param name="newBuilding">Новый объект типа Building</param>
        public void AddBuilding(Building newBuilding)
        {
            _listBuilding.Add(newBuilding);
        }
        
        /// <summary>
        /// Изменяет объект Здание.
        /// </summary>
        /// <param name="Building">Измененый объект типа Building</param>
        public void UpdateBuilding(Building building)
        {
            int index = _listBuilding.FindIndex(x => x.Id == building.Id);
            _listBuilding[index] = building;
        }

        /// <summary>
        /// Возращает иднтификатор записи.
        /// </summary>
        /// <param name="building">Сущность Здание</param>
        /// <returns>Идентификатор записи</returns>
        public long GetId(Building building)
        {
            return building.Id;
        }
    }
}
