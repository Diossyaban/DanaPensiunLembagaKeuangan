using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using DPLK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using DPLK.Models.Dto;
using DPLK.Service;
using DPLK.Models.context;
using System.Diagnostics;
using DPLK.Controllers.Menu;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using System.Linq;
using DPLK.Interface;

namespace DPLK.Controllers
{
    public class HomeController : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IAccountService _accountService;
/*        private readonly UserManager<TUser> _userManager;
*/
        public HomeController(ILogger<HomeController> logger,
            PensionContext context, IConfiguration configuration, 
            IAccountService service, IWebHostEnvironment hostingEnvironment, 
            IAccountService accountService)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Pension");
            _logger = logger;   
            _hostingEnvironment = hostingEnvironment;
            _accountService = accountService;
/*            _userManager = userManager;
*/            //_signInManager = signInManager;
            //_serviceManager = service;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
           /* var myEmail = await _userManager.FindByEmailAsync(User.Identity.Name);
            var myJabatan = await _userManager.FindByIdAsync(User.Identity.Name);*/
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
