using System.Collections.Generic;

namespace VesperrBackHomePage.Models
{
    public class PricingCategory
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public List<PricingInfo> PricingInfos { get; set; }
    }
}
