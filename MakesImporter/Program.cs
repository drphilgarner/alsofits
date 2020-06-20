using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using CsvHelper;
using Dapper;

namespace MakesImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening makes and models file");
            var finalMakeAndModels = new List<MakeAndModels>();

            using (var sr = new StreamReader("makesAndModels.csv"))
            using (var csv = new CsvReader(sr, System.Globalization.CultureInfo.InvariantCulture)){
                            
                csv.Configuration.HasHeaderRecord = false;

                var records = csv.GetRecords<MakeAndModel>().ToList();
                
                var distinctModels = from r in records
                                    where !r.BaseModel.Contains("MISSING")
                                    group r by new {
                                        r.Make,
                                        r.BaseModel
                                        //r.BaseModelLonger
                                    } 
                                    
                                    into simpleModel select new 
                                    { 
                                        make = simpleModel.Key.Make, 
                                        model = simpleModel.Key.BaseModel
                                        //longerModel = simpleModel.Key.BaseModelLonger                                       
                                    };
                
                var atAirport = distinctModels.ToList();

                //create a hierarchy with a subquery
                foreach(var make in atAirport.Select(t => t.make )){
                    if (!finalMakeAndModels.Any(t => t.Make == make))
                    {
                        finalMakeAndModels.Add(new MakeAndModels {Make = make, 
                            CarModels = atAirport.Where(t => t.make == make).Select(t => new CarModel{
                                ModelName = t.model
                                // TrimLevels = (from r in records
                                //         where r.BaseModel == t.model
                                //         && r.Make == t.make
                                //         select r.ModelDetail)?.ToList()
                            }).ToList()
                        });
                    }
                }

                var insertManufacturer = "INSERT INTO tbl_Manufacturer (FullName) OUTPUT INSERTED.[ManufacturerId] values (@FullName);";
                var insertModel = "INSERT INTO tbl_Model (FullName, ManufacturerId) OUTPUT INSERTED.[ModelId] values (@FullName, @ManufacturerId)";


                var connStr = new SqlConnectionStringBuilder{
                    DataSource = "192.168.1.94",
                    InitialCatalog = "alsofits",
                    Password = "t6;h5W`AVTv[L+>7",
                    UserID = "sa"
                };

                using (var conn = new SqlConnection(connStr.ToString())){
                    

                    foreach(var f in finalMakeAndModels){

                        var manufacturerRow = conn.QuerySingle<int>(insertManufacturer, new {FullName = f.Make} );
                        
                        Console.WriteLine($"Make: {f.Make} row is {manufacturerRow}");
                        foreach(var m in f.CarModels){

                            var modelRow = conn.QuerySingle<int>(insertModel, new {FullName = m.ModelName, ManufacturerId = manufacturerRow});
                            Console.WriteLine($"{m.ModelName}");

                            // var trims = $"Trims: {String.Join(", ",m.TrimLevels)}";
                            // Console.WriteLine(trims);
                            
                        }
                    }
                }

            }
            
        }
        
    }

    class MakeAndModels{
        

        public string Make { get; set; }
        public List<CarModel> CarModels {get; set;} = new List<CarModel>();
    }

    class CarModel{
        public string ModelName { get; set; }
        public List<string> TrimLevels { get; set; }
        
    }

    class MakeAndModel{
        public string Make { get; set; }
        public string ModelDetail { get; set; }

        public string BaseModel {
            get {
            return ModelDetail?.Split(" ").FirstOrDefault(); 
            }
        }

        public string BaseModelLonger{
            get {
                var twoStrings = ModelDetail?.Split(" ").Take(2).ToList();
                if (twoStrings.Count != 2)
                    return String.Empty;
                
                return $"{twoStrings[0]} {twoStrings[1]}";
            }
        }
    }
}
