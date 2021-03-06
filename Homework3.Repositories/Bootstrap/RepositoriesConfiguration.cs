﻿using Homework3.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Homework3.Repositories.Bootstrap
{
    /// <summary>
    /// Расширения для конфигурации репозиториев.
    /// </summary>
    public static class RepositoriesConfiguration
    {
        /// <summary>
        /// Конфигурирование репозиториев.
        /// </summary>
        /// <param name="services">Коллекция сервисов из Startup.</param>
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBuildingRepository, BuildingRepository>();
            services.AddScoped<IConstructionCompanyRepository, ConstructionCompanyRepository>();
        }
    }
}
