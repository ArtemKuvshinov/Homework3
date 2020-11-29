using Microsoft.EntityFrameworkCore;
using Homework3.DAL.Domain;
using System.Threading;
using System;

namespace Homework3.DAL.Contexts
{
    /// <summary>
    /// Контекс для работы с БД "Здания".
    /// </summary>
    public class Homework3Context : DbContext
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="Homework3Context"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public Homework3Context(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        /// <summary>
        /// Здания.
        /// </summary>
        public DbSet<Building> Buildings { get; set; }

        /// <summary>
        /// Строительные компании.
        /// </summary>
        public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }

        /// <summary>
        /// Материалы.
        /// </summary>
        public DbSet<Material> Materials { get; set; }

        /// <summary>
        /// Маериалы используемые в конкетном здании.
        /// </summary>
        public DbSet<BuildingСomposition> BuildingСompositions { get; set; }

        public void SaveChanges(CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
