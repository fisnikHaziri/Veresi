using Microsoft.AspNetCore.Mvc;

namespace Veresi.Controllers
{
    public class Person : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
