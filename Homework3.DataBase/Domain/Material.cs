using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3.DAL.Domain
{
    /// <summary>
    /// Строительный материал.
    /// </summary>
    public class Material : BaseEntity
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
        /// Единица измерения.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Unit { get; set; }

        /// <summary>
        /// Срок службы.
        /// </summary>
        [Required]
        public int LifeTime { get; set; }
    }
}
