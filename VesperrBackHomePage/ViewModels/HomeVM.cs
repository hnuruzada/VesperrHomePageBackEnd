using System.Collections.Generic;
using VesperrBackHomePage.Models;

namespace VesperrBackHomePage.ViewModels
{
    public class HomeVM
    {
        public List<GetStarted> GetStarteds { get; set; }
        public List<Client> Clients { get; set; }
        public List<AboutUs> AboutUs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Question> Questions { get; set; }
        public List<Count> Counts { get; set; }
        public List<Service> Services { get; set; }
        public List<MoreService> MoreServices { get; set; }
        public List<Feature> Features { get; set; }
        public List<Testimonial> Testimonials { get; set; }
       public List<PricingCategory> PricingCategories { get; set; }
    }
}
