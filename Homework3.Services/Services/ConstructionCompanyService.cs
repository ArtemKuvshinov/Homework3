using Homework3.Models.DTO;
using Homework3.Repositories.Interfaces;
using Homework3.Services.Interfaces;
using System.Collections.Generic;
using System.Threading;

namespace Homework3.Services.Services
{
    public class ConstructionCompanyService : IConstructionCompanyService
    {
        private readonly IConstructionCompanyRepository _repository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        public ConstructionCompanyService(IConstructionCompanyRepository repository)
        {
            _repository = repository;
        }

        ///<inheritdoc cref="ICreatable{TDto}.Create(TDto)"/>
        public ConstructionCompanyDTO Create(ConstructionCompanyDTO dto)
        {
            return _repository.Create(dto);
        }

        /// <inheritdoc cref="IDeletable.Delete(long[])"/>
        public void Delete(params long[] ids)
        {
            _repository.Delete(ids);
        }

        /// <inheritdoc cref="IGettableById{TDto}.Get(long, CancellationToken)"/>
        public ConstructionCompanyDTO Get(long id, CancellationToken token = default)
        {
            return _repository.Get(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.Get(CancellationToken)"/>
        public IEnumerable<ConstructionCompanyDTO> Get(CancellationToken token = default)
        {
            return _repository.Get();
        }


        /// <inheritdoc cref="IUpdatable{TDto}.Update(TDto)"/>
        public ConstructionCompanyDTO Update(ConstructionCompanyDTO dto)
        {
            return _repository.Update(dto);
        }
    }
}
