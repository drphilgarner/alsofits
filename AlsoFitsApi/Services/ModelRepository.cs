using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFits.core.Model;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AlsoFitsApi.Services
{
    public class ModelRepository : IModelRepository
    {
        private readonly IConfiguration _config;
        private IDbConnection _db;
        public ModelRepository(IConfiguration config)
        {
            this._config = config;
            this._db = new SqlConnection(_config.GetConnectionString("prod"));

        }


        public Model GetModel(int modelId)
        {
            return _db.QuerySingle<Model>("SELECT [ModelId],[FullName],[ManufacturerId] from [alsofits].[dbo].[tbl_Model] WHERE [ModelId] = @ModelId", new {ModelId = modelId});
        }

        public IEnumerable<Model> GetModels(int ManufacturerId)
        {
            return _db.Query<Model>("SELECT [ModelId],[FullName] FROM [alsofits].[dbo].[tbl_Model] WHERE [ManufacturerId] = @ManufacturerId",new {ManufacturerId = ManufacturerId});
        }

        public IEnumerable<Model> GetAllModels()
        {
            return _db.Query<Model>("SELECT mod.[ModelId],mod.[ManufacturerId],mod.[FullName], manu.[FullName] as ManufacturerFullName FROM [alsofits].[dbo].[tbl_Model] as mod JOIN [alsofits].[dbo].[tbl_Manufacturer] manu ON mod.[ManufacturerId] = manu.[ManufacturerId] "); 
            
        }

    }


}