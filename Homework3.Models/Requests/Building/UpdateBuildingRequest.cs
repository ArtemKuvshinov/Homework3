using System.ComponentModel.DataAnnotations;

namespace Homework3.Models.Requests.Building
{
    public class UpdateBuildingRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        [StringLength(200)]
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Количетсво этажей.
        /// </summary>
        [Required]
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        [StringLength(16)]
        [Required]
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Назначение здания
        /// </summary>
        [StringLength(200)]
        public string Purpose { get; set; }
    }
}
