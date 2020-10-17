namespace AlsoFitsApi.ApiModel
{
    public class PartCategoryChild{
        public int PartCategoryChildId { get; set; }
        public string FullName { get; set; }

        public PartCategoryParent PartCategoryParent { get; set; }

    }

    


}