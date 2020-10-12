using System.Collections.Generic;

namespace AlsoFitsApi.Controllers.Model
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string FullName { get; set; }

        
    }

    public class Model
    {
        public int ModelId { get; set; }
        public string FullName { get; set; }
        public string  ShortName { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }

    public class Part{
        public int PartId{get;set;}
        public string FullName{get;set;}


        
    }

    public class PartCategoryParent{
        public int PartCategoryParentId { get; set; }
        public string FullName { get; set; }

    }


    public class PartCategoryChild{
        public int PartCategoryChildId { get; set; }
        public string FullName { get; set; }

        public PartCategoryParent PartCategoryParent { get; set; }

    }

    public class PartModel{
        public int PartModelId { get; set; }
        public int PartId;
        public int ModelId;
    }

    


}