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
                                        r.BaseModel,
                                        r.BaseModelLonger
                                    } 
                                    
                                    into simpleModel select new 
                                    { 
                                        make = simpleModel.Key.Make, 
                                        model = simpleModel.Key.BaseModel,
                                        longerModel = simpleModel.Key.BaseModelLonger                                       
                                    };
                
                var atAirport = distinctModels.ToList();

                //create a hierarchy with a subquery
                foreach(var make in atAirport.Select(t => t.make )){
                    if (!finalMakeAndModels.Any(t => t.Make == make))
                    finalMakeAndModels.Add(new MakeAndModels {Make = make, 
                        CarModels = atAirport.Where(t => t.make == make).Select(t => new CarModel{
                            ModelName = t.model,
                            LongerModelName = t.longerModel
                        }).ToList()
                    });
                }

                foreach(var f in finalMakeAndModels){
                    Console.WriteLine($"Make: {f.Make}");
                    foreach(var m in f.CarModels){
                        Console.WriteLine($"{m.ModelName} or even longer {m.LongerModelName}");
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
        public string LongerModelName { get; set; }
        
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
