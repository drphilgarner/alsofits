using System.Collections.Generic;
using AlsoFitsApi.Controllers.Model;
namespace AlsoFitsApi.Services
{
    public interface IManufacturerRepository
    {
         IEnumerable<Manufacturer> GetManufacturers(int amount);


    }

    public interface IModelRepository
    {
        IEnumerable<Model> GetModels(int manufacturerId);

    }

    public interface IPartsRepository
    {
        IEnumerable<Part> GetParts(int modelId, int categoryId);
    }

    public interface ICategoryRepository
    {
        IEnumerable<PartCategoryParent> GetParentCategorys();

        IEnumerable<PartCategoryChild> GetPartCategoryChildren(int parentCategoryId);
    }

}