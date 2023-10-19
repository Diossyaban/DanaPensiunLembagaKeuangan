using Microsoft.AspNetCore.Mvc;

namespace DPLK.Controllers.CashManagement
{
    public class CashManagementController : Controller
    {
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
