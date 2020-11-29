using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Homework3.Services.Interfaces;
using Homework3.Common.Swagger;
using Homework3.Models.DTO;
using AutoMapper;
using Homework3.Models.Requests.Building;
using Homework3.Models.Responses.Building;
using System.Threading;

namespace Homework3.Controllers
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
        private readonly IMapper _mapper;

        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingController"/> c помощью DI.
        /// </summary>
        /// <param name="buildingService">Сервис "Здание".</param>
        /// <param name="logger">Логгер.</param>
        public BuildingController(IBuildingService buildingService, ILogger<BuildingController> logger, IMapper mapper)
        {
            _buildingService = buildingService;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        ///  Получение списка зданий.
        /// </summary>
        /// <returns>Коллекция сущностей Здание</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BuildingResponse>))]
        public IActionResult Get(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Building/Get was requested.");
            var response = _buildingService.Get(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<BuildingResponse>>(response));
        }

        /// <summary>
        /// Получение здания по Id.
        /// </summary>
        /// <returns>Cущность Здание.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BuildingResponse))]
        public IActionResult GetById(long id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Building/GetById was requested.");
            var response = _buildingService.Get(id, cancellationToken);
            return Ok(_mapper.Map<BuildingResponse>(response));
        }

        /// <summary>
        /// Изменение сущности Здание.
        /// </summary>
        /// <returns>Измененная сущность Здание.</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BuildingResponse))]
        public IActionResult Put(UpdateBuildingRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Building/Put was requested.");
            var response = _buildingService.Update(_mapper.Map<BuildingDTO>(request));
            return Ok(_mapper.Map<BuildingResponse>(response));
        }

        /// <summary>
        /// Добавляет новое Здание.
        /// </summary>
        /// <param name="newBuilding">Новая сущность "Здание"</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BuildingResponse), 200)]
        public IActionResult Post(CreateBuildingRequest request)
        {
            _logger.LogInformation("Buildings/Post was requested.");
            var response =_buildingService.Create(_mapper.Map<BuildingDTO>(request));
            return Ok(_mapper.Map<BuildingResponse>(response));
        }

        /// <summary>
        /// Удаление сущностей Здание.
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(CancellationToken cancellationToken, params long[] ids)
        {
            _logger.LogInformation("Building/Delete was requested.");
            _buildingService.Delete(ids);
            return NoContent();
        }

    }
}

