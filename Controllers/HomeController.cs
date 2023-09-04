using Microsoft.AspNetCore.Mvc;

namespace SweetParadiseBakery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.Bakery bakery1 = new()
            {
                Id = 1,
                Name = "Sweet Paradise Bakery",
                Address = "1 Paradise Rd.",
                BakeryValue = 200000.00M,
                FoundingDate = new DateTime(2017, 8, 2)
            };

            return View(bakery1);
        }
    }
}
