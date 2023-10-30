using DPLK.Models;
using DPLK.Models.context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace DPLK.Controllers.Pension.NewBussinesCompany
{

    public class NewBussinesCompany : Controller
    {

        private readonly PensionContext _context;
        private readonly string _connectionString;

        public NewBussinesCompany(ILogger<NewBussinesCompany> logger, PensionContext context, IConfiguration configuration)
        {
            /*            _logger = logger;
            */
            _context = context;

            _connectionString = configuration.GetConnectionString("Pension");
        }

        // GET: NewBussinesCompany
        public IActionResult NewBussinesCompanyIndex()
        {
            Company company = _context.Companies.FirstOrDefault(); // Fetch a single company       

            return View(company);
        }

        // GET: NewBussinesCompany/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public IActionResult NewBusinessCompanyCreate()
        {
            ViewData["ClientNmbr"] = new SelectList(_context.Companies, "ClientNmbr", "ClientNmbr");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewBusinessCompanyCreate(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Companies.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home"); // Redirect to appropriate action and controller
            }

            ViewData["ClientNmbr"] = new SelectList(_context.Companies, "ClientNmbr", "ClientNmbr", company.ClientNmbr);
            return View(company);
        }

        // GET: NewBussinesCompany/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewBussinesCompany/Edit/5
    /*    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // GET: NewBussinesCompany/Delete/5
    /*    public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewBussinesCompany/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
