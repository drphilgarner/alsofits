namespace AlsoFits.core.Model
{
    public class Part{
        public int PartId{get;set;}
        public string FullName{get;set;}

        public string Manufacturer { get; set; }
        
    }

    /// <summary>
    /// Part vendors sell Parts
    /// </summary>
    public class PartVendor
    {
        public int PartVendorId { get; set; }
        public int PartInstanceId { get; set; }
        public string VendorName { get; set; }

        public decimal Price { get; set; }

        public string CurrencyCode { get; set; }
        public string VendorPdpUrl { get; set; }
    }


}