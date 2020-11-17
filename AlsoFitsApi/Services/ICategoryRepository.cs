using System.Collections.Generic;
using AlsoFits.core.Model;



namespace AlsoFitsApi.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<PartCategoryParent> GetParentCategorys();

        IEnumerable<PartCategoryChild> GetPartCategoryChildren(int parentCategoryId);
        IEnumerable<PartCategoryChild> GetAllParts();
    }

}