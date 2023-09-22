using Microsoft.AspNetCore.Mvc;

namespace DNTU_JOBS.Controllers
{
    public class NavbarController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("FindJob")]
        public IActionResult FindJob()
        {
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("/auth/register")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("/auth/login")]

        public IActionResult Login()
        {
            return View();
        }
    }
}
