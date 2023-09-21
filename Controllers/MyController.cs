using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
