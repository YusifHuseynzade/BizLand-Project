using BizLand_21._11._2022.DAL;
using BizLand_21._11._2022.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BizLand_21._11._2022.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BizLandTablesDbContext _context;

        public ServiceController(BizLandTablesDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int id)
        {
            Service service = _context.Services.ToList().Find(x => x.Id == id);

            return View(service);
        }
    }
}
