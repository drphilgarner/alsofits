namespace AlsoFitsApi.Controllers.ApiModel
{
    public class Model
    {
        public int ModelId { get; set; }
        public string FullName { get; set; }
        public string  ShortName { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }

    


}