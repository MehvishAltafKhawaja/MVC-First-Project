using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;
namespace MyFirstProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductForm()
        {
            return View();
        }
        public IActionResult ProductView(Product prod)
        {
            ViewBag.Id = prod.id;
            ViewBag.ProductName = prod.pname;
            ViewBag.Price = prod.price;
            ViewBag.Quantity = prod.quantity;
            return View();

        }
    }
}
