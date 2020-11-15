using System.Collections.Generic;
using AlsoFits.core.Model;

namespace AlsoFitsApi.Services
{
    public interface IPartsRepository
    {
        IEnumerable<Part> GetPartsByModelAndCategory(int modelId, int categoryId);

        void AddPart(IEnumerable<int> compatibleModels, 
                    int partCategoryChildId, 
                    string shortDesc, 
                    string fullDesc, 
                    string purchaseUrl = null, 
                    decimal? price = null, 
                    int? currencyId = null);

        void AddModelToPart(int modelId, int partId);

        PartModel GetPartModel(int modelId, int partId);

    }
}