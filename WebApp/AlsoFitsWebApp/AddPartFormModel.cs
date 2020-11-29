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
        public int PartCategoryId { get; set; }
        [Required]
        public int SourceModelId { get; set; }
        [Required]
        public int DestinationModelId { get; set; }

        [Required]
        public decimal Price { get; set; }

        public char CurrencySymbol {get;set;}

    }
}