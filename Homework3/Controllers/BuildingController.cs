using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Homework2.Services.Interfaces;
using Homework2.Common.Swagger;
using Homework2.Models.DTO;
using Moq;
using Homework2.DataBase.Domain;

namespace Homework2.Controllers
{
    /// <summary>
    /// Контроллер для сущности Здание.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Buildings)]
    public class BuildingController : ControllerBase
    {
        private readonly ILogger<BuildingController> _logger;
        private readonly IBuildingService _buildingService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingController"/> c помощью DI.
        /// </summary>
        /// <param name="buildingService">Сервис "Здание".</param>
        /// <param name="logger">Логгер.</param>
        public BuildingController(IBuildingService buildingService, ILogger<BuildingController> logger)
        {
            _buildingService = buildingService;
            _logger = logger;
        }

        /// <summary>
        /// Получение доступного перечня зданий.
        /// </summary>
        /// <returns>Коллекция сущностей "Здание"</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BuildingDTO>))]
        public IActionResult Get()
        {
            _logger.LogInformation("Buildings/Get was requested.");
            var response = _buildingService.GetBuildings();
            return Ok(response);
        }

        /// <summary>
        /// Получаает иформацию о здании по идентификатору записи.  
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <returns>Объект BuildingDTO</returns>
        /// /// <response code="404">Элемент не найден</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BuildingDTO))]
        public IActionResult Get(long id)
        {
            var response = _buildingService.GetBuilding(id);

            if (response == null)
            {
                _logger.LogInformation("Building/Object not found");
                return NotFound();
            }
            else
            {
                _logger.LogInformation("Building/Object was received");
                return Ok(response);
            }
        }

        /// <summary>
        /// Удаляет здание.
        /// </summary>
        /// <param name="id"></param>        
        /// <response code="404">Элемент не найден</response>  
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(NoContentResult))]
        public IActionResult Delete(long id)
        {
            var deletedBuilding = _buildingService.GetBuilding(id);

            if (deletedBuilding == null)
            {
                _logger.LogInformation("Building/Deleted object not found");
                return NotFound();
            }

            _buildingService.DeleteBuilding(id);
            _logger.LogInformation("Building/Object was deleted");
            return NoContent();
        }

        /// <summary>
        /// Добавляет новое Здание.
        /// </summary>
        /// <param name="newBuilding">Новая сущность "Здание"</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Building), 200)]
        public IActionResult Add([FromBody]Building newBuilding)
        {
            _buildingService.AddBuilding(newBuilding);
            _logger.LogInformation("Building/Object was added.");
            return Ok(newBuilding);
        }

        /// <summary>
        /// Изменяет информацию о здании.
        /// </summary>
        /// <param name="building">Изменяемая сущность</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BuildingDTO))]
        [HttpPut]
        public IActionResult Put(Building building)
        {
            var updatedBuilding = _buildingService.GetBuilding(building.Id);

            if (updatedBuilding == null)
            {
                _logger.LogInformation("Building/Object not found");
                return NotFound();
            }
            else
            {
                _buildingService.UpdateBuilding(building);
                _logger.LogInformation("Building/Object was received");
                return Ok(updatedBuilding);
            }
        }

    }
}

