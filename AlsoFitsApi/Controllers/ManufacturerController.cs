using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlsoFitsApi.Controllers.Model;


namespace AlsoFitsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufacturerController :ControllerBase
    {
        private readonly ILogger<ManufacturerController> _logger;

        public ManufacturerController(ILogger<ManufacturerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Manufacturer> Get()
        {
            return new Manufacturer[] {new Manufacturer {FullName="Maserati", ManufacturerId = 66}};
        }

    }
}