using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VesperrBackHomePage.Models;
using VesperrBackHomePage.ViewModels;


namespace VesperrBackHomePage.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                GetStarteds=_context.GetStarteds.ToList(),
                Clients = _context.Clients.ToList(),
                Categories = _context.Categories.Include(x => x.CardCategories).ThenInclude(x => x.Card).ToList(),
                Employees = _context.Employees.Include(x => x.Socials).ToList(),
                Questions=_context.Questions.ToList(),
                AboutUs=_context.AboutUs.ToList(),
                Counts=_context.Counts.ToList(),
                Services=_context.Services.ToList(),    
                MoreServices=_context.MoreServices.ToList(),
                Features=_context.Features.ToList(),
                Testimonials=_context.Testimonials.ToList(),
                PricingCategories=_context.PricingCategories.Include(x =>x.PricingInfos).ToList()
            };
            
            return View(homeVm);
        }
    }
}
