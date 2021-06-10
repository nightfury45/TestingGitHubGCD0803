using System.Linq;
using System.Web.Mvc;
using TestingGitHubGCD0803.Models;

namespace TestingGitHubGCD0803.Controllers
{
	public class VinhController : Controller
	{
		private ApplicationDbContext _context;
		public VinhController()
		{
			_context = new ApplicationDbContext();
		}
		// GET: Vinh
		public ActionResult Index()
		{
			var orders = _context.Orders.ToList();
			return View(orders);
		}
	}
}