using DPLK.Models;
using DPLK.Models.context;
using DPLK.Models.dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DPLK.Controllers.UserManagement
{
    public class UserManagementController : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        private readonly ILogger<UserManagementController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UserManagementController(ILogger<UserManagementController> logger, PensionContext context, IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Pension");
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;

        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(TUser user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "data has been saved.";
                return RedirectToAction("UserList");
            }

            return View(user);
        }
        // GET: UserManagementController
        public async Task<IActionResult> UserList(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (!string.IsNullOrEmpty(searchString))
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var x = await _context.TUsers.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                x = x
                    .Where(y =>
                        (y.NamaLengkap != null && y.NamaLengkap.ToLower().Contains(searchString.ToLower())) || //number 1 schizo country in the world for a reason
                        (y.Bagian != null && y.Bagian.ToLower().Contains(searchString.ToLower())) ||
                        (y.Jabatan != null && y.Jabatan.ToLower().Contains(searchString.ToLower())) 
                    )
                    .ToList();
            }


            ViewBag.CurrentSort = sortOrder;
            ViewBag.SortOrder = sortOrder == "NamaLengkap" ? "" : "NamaLengkap";

          

        

            return View(x.ToPagedList(pageIndex, defaultSize));
        }

   

        public async Task<IActionResult> EditUser(string id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var user = await _context.TUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(string id, TUser user)
        {
            if (id != user.IdUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "data has been saved.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.IdUser))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("UserList");
            }

            return View(user);
        }
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.TUsers
                .FirstOrDefaultAsync(m => m.IdUser == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.TUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.TUsers.Remove(user);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "User data deleted successfully.";
            return RedirectToAction("UserList");
        }

        private bool UserExists(string id)
        {
            return _context.TUsers.Any(e => e.IdUser == id);
        }

        public async Task<IActionResult> Menu(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 50;
            ViewBag.psize = defaultSize;

            if (!string.IsNullOrEmpty(searchString))
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var x = await _context.TMenus.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                x = x
                    .Where(y =>
                        (y.NamaMenu != null && y.NamaMenu.ToLower().Contains(searchString.ToLower()))  //number 1 schizo country in the world for a reason
                    
                    )
                    .ToList();
            }


         



            return View(x.ToPagedList(pageIndex, defaultSize));
        }
        public async Task<IActionResult> GroupMenu(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 50;
            ViewBag.psize = defaultSize;

            if (!string.IsNullOrEmpty(searchString))
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var x = await _context.TGroupMenus.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                x = x
                    .Where(y =>
                        (y.NamaGroup != null && y.NamaGroup.ToLower().Contains(searchString.ToLower()))  //number 1 schizo country in the world for a reason

                    )
                    .ToList();
            }


            ViewBag.CurrentSort = currentFilter;
            ViewBag.SortOrder = sortOrder == "NamaGroup" ? "" : "NamaGroup";

            switch (sortOrder)
            {
                case "NamaGroup":
                    x = x.OrderBy(address => address.NamaGroup).ToList();
                    break;
                default:
                    x = x.OrderByDescending(address => address.NamaGroup).ToList();
                    break;
            }



            return View(x.ToPagedList(pageIndex, defaultSize));
        }

        public IActionResult CreateMenu()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMenu(TMenu tMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tMenu);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Menu created successfully.";
                return RedirectToAction("Menu");
            }
            return View(tMenu);
        }

        public async Task<IActionResult> EditMenu(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMenu = await _context.TMenus.FindAsync(id);
            if (tMenu == null)
            {
                return NotFound();
            }
            return View(tMenu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMenu(string id, TMenu tMenu)
        {
            if (id != tMenu.IdMenu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tMenu);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Menu updated successfully.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuExists(tMenu.IdMenu))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Menu");
            }
            return View(tMenu);
        }

        private bool MenuExists(string id)
        {
            return _context.TMenus.Any(e => e.IdMenu == id);
        }

    }
}
