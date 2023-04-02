using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.D = 0;
            ViewBag.T = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.D = model.CalculateDiscount();
                ViewBag.T = model.CalculateTotal();
            }
            else
            {
                ViewBag.D = 0;
                ViewBag.T = 0;
            }
             return View(model);
        }
    }
}
