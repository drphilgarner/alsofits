
namespace AlsoFits.core.Model
{
    public class Model
    {
        public int ModelId { get; set; }

        public int ManufacturerId {get;set;}

        public string ManufacturerFullName {get;set;}
        public string FullName { get; set; }

        public string CompoundName {get{
            return $"{ManufacturerFullName} {FullName}";
        }}
    }

    


}