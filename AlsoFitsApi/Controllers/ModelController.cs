using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlsoFitsApi.Services;
using AlsoFits.core.Model;
using Microsoft.AspNetCore.Cors;

namespace AlsoFitsApi.Controllers
{

    [EnableCors("CorsApi")]

    [ApiController]
    [Route("[controller]")]
    public class ModelController : ControllerBase
    {
        private readonly ILogger<ModelController> _logger;
        private readonly IModelRepository _modelRepository;

        public ModelController(ILogger<ModelController> logger, IModelRepository modelRepository)
        {
            _logger = logger;
            this._modelRepository = modelRepository;
        }

        [HttpGet("{Id}")]
        public IEnumerable<Model> Get(int Id)
        {
            return _modelRepository.GetModels(Id);
        }

    }
}