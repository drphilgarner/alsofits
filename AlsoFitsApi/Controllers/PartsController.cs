using System.Collections.Generic;
using System.Linq;
using AlsoFitsApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlsoFitsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartsController : ControllerBase
    {
        private readonly ILogger<PartsController> _logger;
        private readonly IPartsRepository _partsRepository;
        private readonly IModelRepository _modelRepository;

        public PartsController(ILogger<PartsController> logger,
                               IPartsRepository partsRepository,
                               IModelRepository modelRepository)
        {
            _logger = logger;
            this._partsRepository = partsRepository;
            this._modelRepository = modelRepository;
        }

        
        public class Complex { public int number {get;set;} public string word {get;set;}}
        
        [HttpPost]
        public IActionResult Post(AddPartRequest request)

//        public IActionResult Post(Complex request)
        
        {
            _logger.LogInformation("Received AddPartRequest {0} {1} {2}",
                                   request.fullDesc,
                                   request.partCategoryId,
                                   request.compatibleModels?.FirstOrDefault());
            

            if (request.compatibleModels.ToList().Count <2)
                return BadRequest();

            //validate that all the models in the request exist
            foreach (var m in request.compatibleModels)
            {
                var modelResult = _modelRepository.GetModel(m);
                if (modelResult == null)
                    return BadRequest();
            }      

            //add the part
            _partsRepository.AddPart(request.compatibleModels,
                                     request.partCategoryId,
                                     request.shortDesc,
                                     request.fullDesc,
                                     request.purchaseUrl,
                                     request.price,
                                     request.currencyId);    

            return Ok();
        }


        
    }

    public class AddPartRequest
    {
        public List<int> compatibleModels {get;set;} 
        public int partCategoryId {get;set;} 
        public string shortDesc {get;set;} 
        public string fullDesc {get;set;} 
        public string purchaseUrl {get;set;}
        public decimal? price  {get;set;} 
        public int? currencyId {get;set;}
    }

    
}