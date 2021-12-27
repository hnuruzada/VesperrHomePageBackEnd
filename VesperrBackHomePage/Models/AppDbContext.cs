using Microsoft.EntityFrameworkCore;
using System;

namespace VesperrBackHomePage.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<GetStarted> GetStarteds { get; set; }

        public DbSet<Client> Clients { get; set; }
       
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CardCategory> CardCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Social> Socials { get; set; }
        public  DbSet<Question> Questions { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<MoreService> MoreServices { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<PricingCategory> PricingCategories { get; set; }
        public DbSet<PricingInfo> PricingInfos { get; set; }
    }
}
