using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Diagnostics;

namespace Veresi.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var person = await _context.people
                .Include(p => p.Debts)
                .FirstOrDefaultAsync(x => x.id == id);
            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            _context.people.Add(person);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

		public IActionResult Edit(Guid id)
		{
			var item = _context.people.FirstOrDefault(x => x.id == id);
			return View(item);
		}
		[HttpPost]
		public IActionResult Edit(Person person)
		{
			_context.people.Update(person);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		public IActionResult Delete(Guid id)
        {
            var item = _context.people.FirstOrDefault(x => x.id == id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Delete(Person person)
        {
            _context.people.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}
