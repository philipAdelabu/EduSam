using Microsoft.AspNetCore.Mvc;

namespace EduSam.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
