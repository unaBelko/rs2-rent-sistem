using Microsoft.AspNetCore.Mvc;

namespace rs2_rent_sistem_api.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
