using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFitsApi.ApiModel;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Linq;

namespace AlsoFitsApi.Services
{
    public class PartsRepository : IPartsRepository
    {
        private readonly IConfiguration _config;
        private IDbConnection _db;
       
       public PartsRepository(IConfiguration configuration)
       {
           _config = configuration;
            this._db = new SqlConnection(_config.GetConnectionString("prod"));

            
       }

        public void AddModelToPart(int modelId, int partId)
        {
            throw new System.NotImplementedException();
        }

        public int AddPart(IEnumerable<int> compatibleModels, 
                            int partCategoryId, 
                            string shortDesc, 
                            string fullDesc, 
                            string purchaseUrl = null, 
                            decimal? price = null, 
                            int? currencyId = null)
        {
            
            //add the part
            var result = _db.Query(
                "INSERT into [alsofits].[dbo].[tbl_Part] (FullDescription,ShortDescription,PartCategoryId) VALUES ({@FullDescription, @ShortDescription, @PartCategoryId}); SELECT CAST(SCOPE_IDENTITY() as int)",
                new { FullDescription = fullDesc, ShortDescription = shortDesc, PartCategoryId = partCategoryId });

            return (int)result.Single();
        }

        public PartModel GetPartModel(int modelId, int partId)
        {
            return _db.QuerySingle<PartModel>("SELECT [PartModelId],[PartId],[ModelId] from [alsofits].[dbo].[tbl_PartModel] WHERE [ModelId] = {@ModelId} AND [PartId] = {PartId}",
                                              new { ModelId = modelId, PartId = partId });
        }

        public IEnumerable<Part> GetPartsByModelAndCategory(int modelId, int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}