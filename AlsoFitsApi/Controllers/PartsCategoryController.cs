using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlsoFitsApi.Services;
using AlsoFits.core.Model;

namespace AlsoFitsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartsCategoryController : ControllerBase
    {
        private readonly ILogger<PartsCategoryController> _logger;
        private readonly ICategoryRepository _categoryRepository;

        public PartsCategoryController(ILogger<PartsCategoryController> logger, ICategoryRepository _categoryRepository)
        {
            _logger = logger;
            this._categoryRepository = _categoryRepository;
        }

        public IEnumerable<PartCategoryParent> GetAllPartsCategory()
        {
            return _categoryRepository.GetParentCategorys();
        }

        [HttpGet("{parentId}")]
        public IEnumerable<PartCategoryChild> GetPartsCategoryById(int parentId)
        {
            return _categoryRepository.GetPartCategoryChildren(parentId);
        }

    }
}