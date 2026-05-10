using Ecommerce1.Models;
using Ecommerce10.Data;
using Ecommerce10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ecommerce10.Controllers
{
    public class HomeController : Controller
    {

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

		EcommerceContext db;
		ApplicationDbContext db1;
        public HomeController(EcommerceContext context,ApplicationDbContext dbContext)
		{
			db = context;
			db1 = dbContext;
		}

		public IActionResult Index()
		{

			return View();
		}

		public IActionResult books(int id = 5)
		{
			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}
		public IActionResult electronic(int id = 2)
		{
			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}
		public IActionResult fashion(int id = 1)
		{
			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}
		public IActionResult jewellery(int id = 4)
		{
			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}
		public IActionResult software(int id = 3)
		{
			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}
		public IActionResult watch(int id = 6)
		{

			var prod = db.Products.Where(x => x.CategoryId == id).ToList();

			return View(prod);
		}

		public IActionResult cart()
		{
			
			return View();
		}

		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}