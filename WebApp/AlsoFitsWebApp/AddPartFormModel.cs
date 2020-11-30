using System.ComponentModel.DataAnnotations;

namespace AlsoFitsWebApp
{
    public class AddPartFormModel
    {
        [Required]
        public string Description { get; set; } 
        
        [UrlAttribute]
        public string PdpUrl { get; set; }

        [Required]
        public string PartCategory { get; set; }
        [Required]
        public string SourceModel { get; set; }
        [Required]
        public string DestinationModel { get; set; }

        public string PartNumber1 { get; set; }

        public string PartNumber2 { get; set; }

        public string PartNumber3    { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string CurrencySymbol {get;set;}

    }
}