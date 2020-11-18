namespace AlsoFits.core.Model
{
    public class Part{
        public int PartId{get;set;}
        public string FullName{get;set;}

        
        
    }

    public class PartInstance
    {
        public int PartInstanceId {get;set;}

        public int PartId { get; set; }

        public string PartSupplier { get; set; }

        public string PartNumber1 { get; set; }
        public string PartNumber2 { get; set; }
        public string PartNumber3 { get; set; }


    }

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