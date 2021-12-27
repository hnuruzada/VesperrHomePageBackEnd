namespace VesperrBackHomePage.Models
{
    public class PricingInfo
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        

        public int PricingCategoryId { get; set; }
        public PricingCategory PricingCategory { get; set; }
    }
}
