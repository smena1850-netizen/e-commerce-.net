using Ecommerce1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Xml.Linq;



namespace Ecommerce10.Controllers
{
    public class EcommerceController : Controller
    {
        EcommerceContext db;
        public EcommerceController(EcommerceContext context)
        {
            db = context;
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
    }
}
