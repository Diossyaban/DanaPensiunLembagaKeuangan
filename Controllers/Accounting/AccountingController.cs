using DPLK.Models.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DPLK.Controllers.Accounting
{
    public class AccountingController : Controller
    {
        private readonly PensionContext _context;

        public AccountingController(PensionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetupBankIndex()
        {
           /* List<FLPPEntry> banks = _context.FLPPEntries.FromSqlRaw("SELECT * FROM BankTypes").ToList();
*/
            // Kirim data ke view untuk ditampilkan
            return View();
        }
        public IActionResult GLIndex()
        {
            return View();
        }
        public IActionResult GLPajakIndex()
        {
            return View();
        }
        public IActionResult CreateFLPFPPEntryFLP()
        {
            return View();

        }
        public IActionResult CreateFLPFPPEntryFPP()
        {
            return View();
        }
        public IActionResult UnapprovedPenerimaan()
        {
            return View();
        }
        public IActionResult UnapprovedPembayaran()
        {
            return View();
        }
        public IActionResult PostedCDVCRV()
        {
            return View();
        }
        public IActionResult CreateJurnal()
        {
            return View();
        }
        public IActionResult UnapprovedJurnalMemorial()
        {
            return View();
        }
        public IActionResult PostedMemorialJurnal()
        {
            return View();
        }

        public IActionResult RequestDeleteJurnal()
        {
            return View();
        }

    }
}

