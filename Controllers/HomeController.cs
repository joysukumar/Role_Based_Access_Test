using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Register_Login_Test.Models;

namespace Register_Login_Test.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    
        public IActionResult Index()
        {
            return View();
        }
       [Authorize(Roles = "Admin")]
        public IActionResult AdminAccess()
        {
            return View();
        }
        [Authorize(Roles = "User")]
        public IActionResult UserAccess()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
