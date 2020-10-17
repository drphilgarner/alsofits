using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFitsApi.ApiModel;
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

        public IEnumerable<Model> GetModels(int ManufacturerId)
        {
            return _db.Query<Model>("SELECT [ModelId],[FullName] FROM [alsofits].[dbo].[tbl_Model] WHERE [ManufacturerId] = @ManufacturerId",new {ManufacturerId = ManufacturerId});
        }
        
    }


}