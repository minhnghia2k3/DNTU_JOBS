using Microsoft.AspNetCore.Mvc;

namespace DNTU_JOBS.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
