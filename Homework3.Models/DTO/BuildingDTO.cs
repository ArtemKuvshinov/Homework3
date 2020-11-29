﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Homework3.DAL.Domain;

namespace Homework3.Models.DTO
{
   public class BuildingDTO : BaseDto
    {
        /// <summary>
        /// Адрес здания.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        /// <summary>
        ///  Назначение здания.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей.
        /// </summary>
        [Required]
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        [Required]
        [RegularExpression(@"\d{2}[:]\d{6,7}[:]\d{2}[:]\d{2}")]
        public string CadastralNumber { get; set; }
    }
}
