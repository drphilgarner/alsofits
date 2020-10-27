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
        IEnumerable<Part> GetPartsByModelAndCategory(int modelId, int categoryId);

        void AddPart(IEnumerable<int> compatibleModels, 
                    int partCategoryId, 
                    string shortDesc, 
                    string fullDesc, 
                    string purchaseUrl = null, 
                    decimal? price = null, 
                    int? currencyId = null);

        void AddModelToPart(int modelId, int partId);

    }

}