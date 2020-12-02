using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Models.Responses.Building
{
    /// <summary>
    /// Ответ на запросы для позиций Здание.
    /// </summary>
    public class BuildingResponse
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Адрес здания
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///  Назначение здания
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей
        /// </summary>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кадастровый номер
        /// </summary>
        public string CadastralNumber { get; set; }
    }
}
