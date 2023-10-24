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


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateFLPFPP()
        {
            return View();
        }
        // anak nya flp/fpp
        public IActionResult EnterFLP()
        {
            return View();
        }
        public IActionResult QueryFLPPendingApproval()
        {
            return View();
        }
        public IActionResult EnterFPP()
        {
            return View();
        }
        public IActionResult QueryFPPPendingApproval()
        {
            return View();
        }
        //anak" nya create FLP/FPP end

        public IActionResult UnapprovedReceipts()
        {
            return View();
        }
        public IActionResult UnapprovedPayment()
        {
            return View();
        }
        public IActionResult RostedCDVCRV()
        {
            return View();
        }
        public IActionResult DBDirect()
        {
            return View();
        }
        //anak" nya DB Direct 
        public IActionResult CreateDBDirect()
        {
            return View();
        }
        public IActionResult CreateInHouseTransferDBDirect()
        {
            return View();
        }
        public IActionResult CreateDBDirectFormFLPFPP()
        {
            return View();
        }
        public IActionResult CreateBITDBDirect()
        {
            return View();
        }
        //anak" nya DB Direct end
        public IActionResult BankList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BankListIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BankListIndex(SpdInvestBank spdInvestBank)
        {
            if (ModelState.IsValid)
            {
                _contextAcc.SpdInvestBanks.Add(spdInvestBank);
                await _contextAcc.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spdInvestBank);
        }


   
        public IActionResult ClaimRequestAmount()
        {
            return View();
        }
        public IActionResult FundSwitchingClaimReqFundApproval()
        {
            return View();
        }
        public IActionResult UploadClaimTransferDate()
        {
            return View();
        }
        

    }
}
