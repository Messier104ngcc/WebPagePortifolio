using Microsoft.AspNetCore.Mvc;

namespace WebPage.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
