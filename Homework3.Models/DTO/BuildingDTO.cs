using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Models.DTO
{
   public class BuildingDTO
    {
        /// <summary>
        /// Адрес здания
        /// </summary>
        [Required]
        [MaxLength(2000)]
        public string Address { get; set; }

        /// <summary>
        ///  Назначение здания
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей
        /// </summary>
        [Required]
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Площадь здания
        /// </summary>
        [Required]
        public long Square { get; set; }

        /// <summary>
        /// Кадастровый номер
        /// </summary>
        [Required]
        [RegularExpression(@"\d{2}[:]\d{6,7}[:]\d{2}[:]\d{2}")]
        public string CadastralNumber { get; set; }
    }
}
