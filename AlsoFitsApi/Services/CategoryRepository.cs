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
        public IEnumerable<PartCategoryChild> GetAllParts()
        {
            return _db.Query<PartCategoryChild>("SELECT [PartCategoryChildId],[FullName] FROM [tbl_PartCategoryChild]");
        }

        public void AddPart(AddPartFormModel addPartFormModel)
        {
            //todo: validation that this part for this model doesn't already exist

            var insertPartQry = "INSERT INTO tbl_Part (FullDescription, PartCategoryChildId) OUTPUT INSERTED.PartId VALUES (@desc, @catId)";

            //todo: add support for part numbers
            var partId = _db.QuerySingle<int>(insertPartQry, new {desc = addPartFormModel.Description,catId = addPartFormModel.PartCategoryChild.PartCategoryChildId});

            //now relate the part to the model
            var partSourceModelId = _db.QuerySingle<int>(@"INSERT INTO tbl_PartModel (PartId, ModelId) OUTPUT INSERTED.PartModelId VALUES (@partid, @modelid)", new {partid = partId, modelid = addPartFormModel.SourceModelId});
            var partDestModelId = _db.QuerySingle<int>(@"INSERT INTO tbl_PartModel (PartId, ModelId) OUTPUT INSERTED.PartModelId VALUES (@partid, @modelid)", new {partid = partId, modelid = addPartFormModel.DestinationModelId});


            throw new System.NotImplementedException();
        }
    }
}