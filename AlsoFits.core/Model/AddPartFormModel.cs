using System.ComponentModel.DataAnnotations;

namespace AlsoFits.core.Model
{
    public class AddPartFormModel
    {
        [Required]
        public string Description { get; set; } 
        
        [Required(ErrorMessage="Please enter a valid URL where you can buy the part")]
        public string PdpUrl { get; set; }

        [Required]
        public string PartCategory { get; set; }

        public PartCategoryChild PartCategoryChild {get;set;}
       
        
        [Required]
        [Range(1, 99999999, ErrorMessage = "Please choose a valid car model.")]
        public int SourceModelId { get; set; }

        [Required]
        [Range(1, 99999999, ErrorMessage = "Please choose a valid car model to which your part alsofits.")]
        public int DestinationModelId { get; set; }

        [Required]
        public string PartNumber1 { get; set; }

        public string PartNumber2 { get; set; }

        public string PartNumber3    { get; set; }

        [Required]
        [Range(0.01, 25000, ErrorMessage = "Enter a price up to 25,000.")]
        public decimal Price { get; set; }

        public string CurrencySymbol {get;set;}

    }
}