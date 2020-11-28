using Microsoft.Extensions.DependencyInjection;

namespace Homework2.Common.Swagger
{

    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Buildings";
                c.DocumentName = SwaggerDocParts.Buildings;
                c.ApiGroupNames = new[] { SwaggerDocParts.Buildings };
                c.GenerateXmlObjects = true;
            });
        }
    }
}
