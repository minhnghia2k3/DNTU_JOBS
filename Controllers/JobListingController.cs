using Microsoft.AspNetCore.Mvc;

namespace DNTU_JOBS.Controllers
{
    public class JobListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
