using System.Collections.Generic;

namespace VesperrBackHomePage.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<CardCategory> CardCategories { get; set; }
    }
}
