using Microsoft.AspNetCore.Mvc;

namespace WebVendasMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
