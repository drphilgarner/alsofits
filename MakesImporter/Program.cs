using System;
using System.Collections.Generic;
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
            var finalMakeAndModels = new List<MakeAndModels>();

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
                                    
                                    into simpleModel select new 
                                    { 
                                        make = simpleModel.Key.Make, 
                                        model = simpleModel.Key.BaseModel,                                        
                                    };
                
                var atAirport = distinctModels.ToList();

                //create a hierarchy with a subquery
                foreach(var make in atAirport.Select(t => t.make )){
                    if (!finalMakeAndModels.Any(t => t.Make == make))
                    finalMakeAndModels.Add(new MakeAndModels {Make = make, 
                        Models = atAirport.Where(t => t.make == make).Select(t => t.model).ToList()
                    });
                }

            }
            
        }
        
    }

    class MakeAndModels{
        

        public string Make { get; set; }
        public List<String> Models {get; set;} = new List<string>();
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
