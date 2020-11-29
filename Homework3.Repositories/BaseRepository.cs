using Homework3.Repositories.Interfaces.CRUD;
using Homework3.DAL.Domain;
using Homework3.Models.DTO;
using System.Collections.Generic;
using System.Threading;
using AutoMapper;
using Homework3.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Homework3.Repositories
{
    /// <summary>
    /// Базовый класс репозитория для работы с CRUD.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Доменная модель.</typeparam>
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel> where TDto : BaseDto
                                                                                       where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected readonly Homework3Context _сontext;
        protected DbSet<TModel> DbSet => _сontext.Set<TModel>();

        /// <summary>
        /// Инициализирует экземпляр <see cref="BaseRepository{TDto, TModel}"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        protected BaseRepository(Homework3Context context, IMapper mapper)
        {
            _сontext = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Добавление новой сущности.
        /// </summary>
        /// <param name="dto">Новая сущность.</param>
        /// <returns>Новая добавленная сущность DTO.</returns>
        /// <inheritdoc cref="ICreatable{TDto, TModel}.Create(TDto)"/>
        /// 
        public TDto Create(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            DbSet.Add(entity);
            _сontext.SaveChanges();
            return Get(entity.Id);
        }

        /// <summary>
        /// Удаление сущностей.
        /// </summary>
        /// <param name="ids">Идентификатор записи.</param>
        public void Delete(params long[] ids)
        {
            var entities = DbSet.Where(x => ids.Contains(x.Id)).ToList();
            _сontext.RemoveRange(entities);
            _сontext.SaveChanges();
        }

        /// <summary>
        /// Показывает сущность по идентификатору записи.
        /// </summary>
        /// <param name="id">Идентификатор записи.</param>
        /// <returns>Экземпляр сущности DTO.</returns>
        public TDto Get(long id)
        {
            var entity = DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
            return _mapper.Map<TDto>(entity);
        }

        /// <summary>
        /// Список экземпляров сущностей.
        /// </summary>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Список экзепляров DTO.</returns>
        ///  /// <inheritdoc cref="IGettable{TDto, TModel}.Get(CancellationToken)"/>
        public IEnumerable<TDto> Get(CancellationToken token = default)
        {
            return _mapper.Map<IEnumerable<TDto>>(DbSet.AsNoTracking().ToList());            
        }

        /// <summary>
        /// Изменяет экземпляр сущности.
        /// </summary>
        /// <param name="dto">Изменяемая сущность DTO</param>
        /// <returns>Измененный экземпляр сущности.</returns>
        public TDto Update(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);

            _сontext.Update(entity);
            _сontext.SaveChanges();

            var newEntity = Get(entity.Id);
            return _mapper.Map<TDto>(newEntity);
        }

    }
}
