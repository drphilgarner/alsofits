using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFits.core.Model;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AlsoFitsApi.Services
{
    public class CatergoryRepository : ICategoryRepository
    {
        private readonly IConfiguration _config;
        private IDbConnection _db;
        public CatergoryRepository(IConfiguration config)
        {
            this._config = config;
            this._db = new SqlConnection(_config.GetConnectionString("prod"));

        }
        
        public IEnumerable<PartCategoryParent> GetParentCategorys()
        {
            return _db.Query<PartCategoryParent>("SELECT [PartCategoryParentId], [FullName] from [tbl_PartCategoryParent]");
        }

        public IEnumerable<PartCategoryChild> GetPartCategoryChildren(int parentCategoryId)
        {
            return _db.Query<PartCategoryChild>("SELECT [PartCategoryChildId],[FullName] FROM [tbl_PartCategoryChild] WHERE [PartCategoryParentId] = @PartCategoryParentId",new {PartCategoryParentId = parentCategoryId});
        }

    }
}