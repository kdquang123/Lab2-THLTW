using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
