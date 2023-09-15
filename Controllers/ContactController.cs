using Microsoft.AspNetCore.Mvc;

namespace DNTU_JOBS.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
