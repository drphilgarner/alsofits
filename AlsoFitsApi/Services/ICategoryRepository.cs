using System.Collections.Generic;
using AlsoFitsApi.ApiModel;



namespace AlsoFitsApi.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<PartCategoryParent> GetParentCategorys();

        IEnumerable<PartCategoryChild> GetPartCategoryChildren(int parentCategoryId);
    }

}