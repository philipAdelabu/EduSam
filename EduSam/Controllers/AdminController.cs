using Microsoft.AspNetCore.Mvc;

namespace EduSam.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
