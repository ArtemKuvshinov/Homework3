using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3.DAL.Domain
{
    /// <summary>
    /// Материалы используемые при строительстве здания.
    /// </summary>
   public class BuildingСomposition : BaseEntity
    {
        /// <summary>
        /// Здание.
        /// </summary>
        public Building Building { get; set; }

        /// <summary>
        /// Материал.
        /// </summary>
        public Material Material { get; set; }        
    }
}
