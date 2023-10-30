using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using DPLK.Controllers.Pension;
using DPLK.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;
using X.PagedList;
using DPLK.ModelAcc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.CodeAnalysis.Differencing;
using System.IO;
using DPLK.Models.context;

namespace DPLK.Controllers.CashManagement
{
    public class CashManagementController : Controller
    {
        private readonly PensionContext _context;
        private readonly PensionAccContext _contextAcc;

        private readonly string _connectionString;
        private readonly string _connectionStrings;

        public CashManagementController(ILogger<CashManagementController> logger, PensionContext context, PensionAccContext contextAcc, IConfiguration configuration)
        {
            /*            _logger = logger;
            */
            _context = context;
            _contextAcc = contextAcc;
            _connectionString = configuration.GetConnectionString("Pension");
            _connectionStrings = configuration.GetConnectionString("PensionAcc");

        }

        //--- BankList ---
        public async Task<IActionResult> BankList(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
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

            var companyIndex = await _contextAcc.SpdInvestBanks.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                companyIndex = companyIndex.Where(address =>
                address.Code != null &&
                address.Code.ToString().ToLower().Contains(searchString.ToLower())
            ).ToList();
            }

            ViewBag.CurrentSort = sortOrder;
            ViewBag.SortOrder = sortOrder == "Code" ? "" : "Code";

            switch (sortOrder)
            {
                case "Code":
                    companyIndex = companyIndex.OrderBy(address => address.Code).ToList();
                    break;
                default:
                    companyIndex = companyIndex.OrderByDescending(address => address.Code).ToList();
                    break;
            }
            return View(companyIndex.ToPagedList(pageIndex, defaultSize));
        }

        //Modif|24-10-2023|DwiPrasetyo

        [HttpGet]
        public IActionResult BankListIndex()
        {
            return View();
        }

        // Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankListIndex(SpdInvestBank spdInvestBank)
        {
            if (ModelState.IsValid)
            {
                _contextAcc.SpdInvestBanks.Add(spdInvestBank);
                await _contextAcc.SaveChangesAsync();
                return RedirectToAction(nameof(BankList));
            }
            return View(spdInvestBank);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBankConfirmation(int id)
        {
            var bank = await _contextAcc.SpdInvestBanks.FindAsync(id);
            if (bank == null)
            {
                return NotFound();
            }

            ViewBag.Code = id; // Gunakan ViewBag.Code

            return View(bank);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBank(int id)
        {
            try
            {
                var bankToDelete = await _contextAcc.SpdInvestBanks.FindAsync(id);
                if (bankToDelete == null)
                {
                    return NotFound();
                }

                _contextAcc.SpdInvestBanks.Remove(bankToDelete);
                await _contextAcc.SaveChangesAsync();

                TempData["SuccessMessage"] = "Bank deleted successfully.";

                return RedirectToAction("BankList");
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the bank.";
                return RedirectToAction("BankList");
            }
        }


        public IActionResult FundSwitchingClaimReqFundApproval()
        {
            return View();
        }


        public IActionResult EnterFLP()
        {
            return View();
        }
    }
}

//End Modif|24-10-2023|DwiPrasetyo