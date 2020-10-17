using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using AlsoFitsApi.Services;
using AlsoFitsApi.ApiModel;

namespace AlsoFitsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufacturerController :ControllerBase
    {
        private readonly ILogger<ManufacturerController> _logger;
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerController(ILogger<ManufacturerController> logger, IManufacturerRepository manufacturerRepository)
        {
            _logger = logger;
            this._manufacturerRepository = manufacturerRepository;
        }

        [HttpGet]
        public IEnumerable<Manufacturer> Get()
        {
            //return new Manufacturer[] {new Manufacturer {FullName="Maserati", ManufacturerId = 66}};
            return _manufacturerRepository.GetManufacturers();
        }

    }
}