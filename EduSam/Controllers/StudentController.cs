using Microsoft.AspNetCore.Mvc;

namespace EduSam.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
