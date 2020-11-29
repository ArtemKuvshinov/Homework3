using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3.DAL.Domain
{
    /// <summary>
    /// Здание.
    /// </summary>
    public class Building : BaseEntity
    {
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

        /// <summary>
        /// Застройщик.
        /// </summary>
        public ConstructionCompany ConstructionCompany { get; set;}
    }
}
