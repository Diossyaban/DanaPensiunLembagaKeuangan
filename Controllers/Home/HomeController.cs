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
using DPLK.Controllers.Menu;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using System.Linq;

namespace DPLK.Controllers
{
    public class HomeController : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        //private readonly UserManager<User> _userManager;
        //private readonly SignInManager<User> _signInManager;
        //private readonly IAccountService _serviceManager;

        public HomeController(ILogger<HomeController> logger,
            PensionContext context, IConfiguration configuration, 
            IAccountService service, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Pension");
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            //_userManager = userManager;
            //_signInManager = signInManager;
            //_serviceManager = service;
        }

        [Authorize]
        public IActionResult Index()
        {
            
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

        public ActionResult GetMenuList()
        {
            try
            {
                var result = _context.TMenus
                    .Select(m => new DPLK.Models.TMenu
                    {
                        IdGroup = m.IdGroup,
                        IdMenu = m.IdMenu,
                        IdParent = m.IdParent,
                        NamaMenu = m.NamaMenu,
                        Url = m.Url,
                        Level = m.Level,
                        StatusMenu = m.StatusMenu,
                    })
                    .ToList();

                return View("Menu", result);
            }
            catch (System.Exception ex)
            {
                var error = ex.Message.ToString();
                return Content("Error");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
