using Microsoft.AspNetCore.Mvc;

namespace DPLK.Controllers.InestmentManagement
{
    public class InvestmentManagementController : Controller
    {
        public IActionResult UnapprovedReceiptIndex()
        {
            return View();
        }
        public IActionResult UnapprovedPaymentsIndex()
        {
            return View();
        }
        public IActionResult PostedJournals()
        {
            return View();
        }
        public IActionResult RequestAmount()
        {
            return View();
        }
        //anak req amount
        public IActionResult ClaimRequestAmount()
        {
            return View();
        }
        public IActionResult FundSwitchingReqFundApproval()
        {
            return View();
        }
        public IActionResult CreateDBDirectFromFLPFPP()
        {
            return View();
        }
        public IActionResult CreateDBDirectBIT()
        {
            return View();
        }
        //anak req amount end
    }
}
