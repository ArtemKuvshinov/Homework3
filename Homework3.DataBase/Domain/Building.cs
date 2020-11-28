using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2.DataBase.Domain
{
    /// <summary>
    /// Здание.
    /// </summary>
   public class Building
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название улицы на которой назодится здание.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Номер здания
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Назначение здания
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей
        /// </summary>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Площадь здания
        /// </summary>
        public long Square { get; set; }

        /// <summary>
        /// Кадастровый номер
        /// </summary>
        public string CadastralNumber { get; set; }

    }
}
