using System;
using System.Collections.Generic;
using System.Text;
using Homework3.Models.DTO;
using Homework3.Services.Interfaces;
using AutoMapper;
using Homework3.DAL.Domain;
using System.Linq;
using Homework3.DAL.Contexts;
using Homework3.Repositories.Interfaces;
using System.Threading;

namespace Homework3.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными "Здание".
    /// </summary>
    /// <inheritdoc cref="IBuildingService"/>
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        public BuildingService(IBuildingRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.Create(TDto)"/>
        public BuildingDTO Create(BuildingDTO dto)
        {
            return _repository.Create(dto);
        }

        /// <inheritdoc cref="IGettableById{TDto}.Get(long, CancellationToken)"/>
        public BuildingDTO Get(long id, CancellationToken token = default)
        {
            return _repository.Get(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.Get(CancellationToken)"/>
        public IEnumerable<BuildingDTO> Get(CancellationToken token = default)
        {
            return _repository.Get();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.Update(TDto)"/>
        public BuildingDTO Update(BuildingDTO dto)
        {
            return _repository.Update(dto);
        }

        /// <inheritdoc cref="IDeletable.Delete(long[])"/>
        public void Delete(params long[] ids)
        {
            _repository.Delete(ids);
        }

    }
}
