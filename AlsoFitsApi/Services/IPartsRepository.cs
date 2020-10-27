using System.Collections.Generic;
using AlsoFitsApi.ApiModel;

namespace AlsoFitsApi.Services
{
    public interface IPartsRepository
    {
        IEnumerable<Part> GetPartsByModelAndCategory(int modelId, int categoryId);

        int AddPart(IEnumerable<int> compatibleModels, 
                    int partCategoryId, 
                    string shortDesc, 
                    string fullDesc, 
                    string purchaseUrl = null, 
                    decimal? price = null, 
                    int? currencyId = null);

        void AddModelToPart(int modelId, int partId);

        PartModel GetPartModel(int modelId, int partId);

    }
}