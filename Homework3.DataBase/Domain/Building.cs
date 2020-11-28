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
        /// Идентификатор записи.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        [StringLength(150)]
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
        [StringLength(150)]
        public string Purpose { get; set; }

        /// <summary>
        /// Застройщик.
        /// </summary>
        public ConstructionCompany ConstructionCompany { get; set;}






        /// <summary>
        /// 
        /// Название улицы на которой назодится здание.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Номер здания
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Площадь здания
        /// </summary>
        public long Square { get; set; }
    }
}
