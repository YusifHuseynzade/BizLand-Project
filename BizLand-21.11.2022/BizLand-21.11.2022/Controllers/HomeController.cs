using BizLand_21._11._2022.DAL;
using BizLand_21._11._2022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizLand_21._11._2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly BizLandTablesDbContext _context;
        

        public HomeController(BizLandTablesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                Feature = _context.Features.ToList(),
                Service = _context.Services.ToList(),
                Testimonial = _context.Testimonials.ToList(),
            };
            return View(viewModel);
        }

    }
}
