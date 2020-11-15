using System.Collections.Generic;
using AlsoFits.core.Model;



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