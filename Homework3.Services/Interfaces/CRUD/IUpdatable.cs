﻿namespace Homework3.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для изменения сущности.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IUpdatable<TDto>
    {
        /// <summary>
        /// Изменение сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        /// <returns>Обновленная сущность.</returns>
        TDto Update(TDto dto);
    }
}