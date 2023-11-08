using Microsoft.AspNetCore.Mvc;

namespace SalesProject.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
