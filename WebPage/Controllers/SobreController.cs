using Microsoft.AspNetCore.Mvc;

namespace WebPage.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
