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

        Model GetModel(int modelId);
    }

}