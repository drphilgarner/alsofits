using System;
using System.IO;
using System.Linq;
using CsvHelper;

namespace MakesImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening makes and models file");

            using (var sr = new StreamReader("makesAndModels.csv"))
            using (var csv = new CsvReader(sr, System.Globalization.CultureInfo.InvariantCulture)){
                            
                csv.Configuration.HasHeaderRecord = false;

                var records = csv.GetRecords<MakeAndModel>();
                
                var distinctModels = from r in records
                                    where !r.BaseModel.Contains("MISSING")
                                    group r by new {
                                        r.Make,
                                        r.BaseModel
                                    } 
                                    
                                    into simpleModel select new { make = simpleModel.Key.Make, model = simpleModel.Key.BaseModel };
                
                var atAirport = distinctModels.ToList();

                foreach (var m in atAirport)
                {
                    Console.WriteLine($"Make {m.make} Model {m.model}");
                }

            }
            
        }
        
    }

    class MakeAndModel{
        public string Make { get; set; }
        public string ModelDetail { get; set; }

        public string BaseModel {
            get {
            return ModelDetail?.Split(" ").FirstOrDefault(); 
            }
        }
    }
}
