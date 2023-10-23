using DPLK.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DPLK.Controllers.Account
{
    [Route("account")]
    public class AccountController : Controller
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
        
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {


            return RedirectToAction("Login");
        }

    }
}
