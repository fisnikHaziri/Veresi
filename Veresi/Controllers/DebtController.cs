using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace Veresi.Controllers
{
	public class DebtController : Controller
	{
		private readonly ApplicationDbContext _context;
        public DebtController(ApplicationDbContext context)
        {
			_context = context; 
        }
        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create(Guid PersonId)
		{
			var newDebt = new Debt
			{
				PersonId = PersonId
			};
			return View(newDebt);
		}
		[HttpPost]
		public IActionResult Create(Debt Debt)
		{
			_context.debts.Add(Debt);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}
	}
}
