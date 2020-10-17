using System.Collections.Generic;
using AlsoFitsApi.ApiModel;



namespace AlsoFitsApi.Services
{
    public interface IManufacturerRepository
    {
         IEnumerable<Manufacturer> GetManufacturers();

    }

    public interface IModelRepository
    {
        IEnumerable<Model> GetModels(int manufacturerId);
    }

    public interface IPartsRepository
    {
        IEnumerable<Part> GetParts(int modelId, int categoryId);
    }

}