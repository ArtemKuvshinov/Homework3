using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3.DAL.Domain
{
    /// <summary>
    /// Строительная компания.
    /// </summary>
    public class ConstructionCompany : BaseEntity
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        [StringLength(300)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        [StringLength(100)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
