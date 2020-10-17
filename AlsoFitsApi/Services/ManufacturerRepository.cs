using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AlsoFitsApi.Controllers.ApiModel;
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

    
}