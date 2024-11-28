using Microsoft.AspNetCore.Mvc;

namespace WebPage.Controllers
{
    public class ProjetosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
