using Homework3.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Homework3.DAL.Bootstrap
{
    /// <summary>
    /// Конфигурации БД.
    /// </summary>
    public static class DbConfigurations    
    {
        /// <summary>
        /// Подключение DbContext.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Homework3Context>(    
                options => options.UseNpgsql(
                    configuration.GetConnectionString(nameof(Homework3Context)),
                    builder => builder.MigrationsAssembly(typeof(Homework3Context).Assembly.FullName))
            );
        }
    }
}
