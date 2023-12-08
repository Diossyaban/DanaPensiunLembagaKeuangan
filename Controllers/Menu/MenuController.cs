using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using DPLK.Models.context;
using DPLK.Controllers.UserManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DPLK.Controllers.Menu
{
    public class MenuController : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        private readonly ILogger<MenuController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public MenuController(ILogger<MenuController> logger, PensionContext context, IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Pension");
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;

        }


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetMenuList()
        {
            try
            {
                var result = (from m in _context.TMenus
                              select new DPLK.Models.TMenu
                              {
                                  IdGroup = m.IdGroup,
                                  IdMenu = m.IdMenu,
                                  IdParent = m.IdParent,
                                  NamaMenu = m.NamaMenu,
                                  Url = m.Url,
                                  Level = m.Level,
                                  StatusMenu = m.StatusMenu,

                              }).ToList();

                return View("Menu", result);
            }
            catch (System.Exception ex)
            {
                var error = ex.Message.ToString();
                return Content("Error");
            }
        }


    }
}
