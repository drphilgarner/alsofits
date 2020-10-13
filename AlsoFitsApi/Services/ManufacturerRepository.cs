using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFitsApi.Controllers.Model;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AlsoFitsApi.Services
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly IConfiguration _config;
        private IDbConnection _db;
        public ManufacturerRepository(IConfiguration config)
        {
            this._config = config;
            this._db = new SqlConnection(_config.GetConnectionString("prod"));

        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return _db.Query<Manufacturer>("SELECT [ManufacturerId],[FullName] FROM [alsofits].[dbo].[tbl_Manufacturer]");
        }
    }

    public class ModelRepository : IModelRepository
    {
        public IEnumerable<Model> GetModels(int manufacturerId)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CatergoryRepository : ICategoryRepository
    {
        public IEnumerable<PartCategoryParent> GetParentCategorys()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PartCategoryChild> GetPartCategoryChildren(int parentCategoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}