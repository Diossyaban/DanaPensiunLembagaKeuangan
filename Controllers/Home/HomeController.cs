using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using DPLK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using DPLK.Models.dto;
using DPLK.Service;
using DPLK.Models.context;
using System.Diagnostics;

namespace DPLK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PensionContext _context;
        //private readonly UserManager<User> _userManager;
        //private readonly SignInManager<User> _signInManager;
        //private readonly IAccountService _serviceManager;

        public HomeController(ILogger<HomeController> logger,
            PensionContext context, IAccountService service)
        {
            _logger = logger;
            //_userManager = userManager;
            //_signInManager = signInManager;
            _context = context;
            //_serviceManager = service;
        }

        [Authorize]
        public IActionResult Index()
        {
            /*            var myUser = await _userManager.GetUserAsync(User);
            */
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyProfile ()
        {
            return View();
        }
        public IActionResult Coba1()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
