using DPLK.Models.Dto;
using DPLK.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace DPLK.Controllers.Account
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _accountService.LoginAsync(model.Email, model.Password);
                try
                {
                    if (loginResult)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (System.Exception ex)
                {
                    TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                    return RedirectToAction("Index");
                }
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