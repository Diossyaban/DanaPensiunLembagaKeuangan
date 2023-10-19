using Microsoft.AspNetCore.Mvc;

namespace DPLK.Controllers
{
    public class CustomerServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ClaimRegister()
        {
            return View();
        }
        //anak claim reg 
        public IActionResult SearchClaimReg()
        {
            return View();
        }
        public IActionResult CreateClaimReg()
        {
            return View();
        }
        public IActionResult SetupBasicRequestClaim()
        {
            return View();
        }
        //anak claim reg end
        public IActionResult InquiriesCS()
        {
            return View();
        }
        public IActionResult ClientInfo()
        {
            return View();
        }
        public IActionResult Mandiri2()
        {
            return View();
        }
        //anak mandiri 2
        public IActionResult SearchMandiri()
        {
            return View();
        }
        public IActionResult RegistrasiMandiri2()
        {
            return View();
        }
        public IActionResult ProcessMandiri2()
        {
            return View();
        }
        public IActionResult ClientSuratPengantarPengalihan()
        {
            return View();
        }
        public IActionResult SuratPengalihan()
        {
            return View();
        }

        //anak mandiri 2 end
        public IActionResult ReportCS()
        {
            return View();
        }
        //anak report
        public IActionResult RekapitulasiPesertaMandiri2()
        {
            return View();
        }
        public IActionResult RekapitulasiKlaimPeserta()
        {
            return View();
        }
        //anak report end
    }
}
