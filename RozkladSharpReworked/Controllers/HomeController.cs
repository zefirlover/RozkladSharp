using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RozkladSharp.DomainServices;

namespace RozkladSharpReworked.Controllers
{
    public class HomeController : Controller
    {
        RozkladSharpDbContext _context;
        public HomeController(RozkladSharpDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }
    }
}