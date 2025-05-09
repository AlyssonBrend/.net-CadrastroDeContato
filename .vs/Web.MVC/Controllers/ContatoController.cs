using Microsoft.AspNetCore.Mvc;

namespace Web.MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
